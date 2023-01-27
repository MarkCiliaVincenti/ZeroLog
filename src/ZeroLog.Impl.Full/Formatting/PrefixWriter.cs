using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ZeroLog.Formatting;

internal class PrefixWriter
{
    private readonly PatternPart[] _parts;

    public string Pattern { get; }

    public PrefixWriter(string pattern)
    {
        Pattern = pattern;
        _parts = OptimizeParts(ParsePattern(pattern)).ToArray();
    }

    private static IEnumerable<PatternPart> ParsePattern(string pattern)
    {
        var position = 0;

        var matches = Regex.Matches(
            pattern,
            """
            %(?:
                (?<part>\w+)
                |
                \{
                    \s* (?<part>\w+) \s*
                    (?:
                        : \s* (?<format>.*?) \s*
                    )?
                \}
            )
            """,
            RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace
        );

        foreach (Match? match in matches)
        {
            if (position < match!.Index)
                yield return new PatternPart(pattern.Substring(position, match.Index - position));

            var format = match.Groups["format"] is { Success: true } formatGroup
                ? formatGroup.Value
                : null;

            var part = match.Groups["part"].Value.ToLowerInvariant() switch
            {
                "date"   => new PatternPart(PatternPartType.Date, format),
                "time"   => new PatternPart(PatternPartType.Time, format),
                "thread" => new PatternPart(PatternPartType.Thread, format),
                "level"  => new PatternPart(PatternPartType.Level, format),
                "logger" => new PatternPart(PatternPartType.Logger, format),
                _        => new PatternPart(match.Value)
            };

            yield return ValidatePart(part);

            position = match.Index + match.Length;
        }

        if (position < pattern.Length)
            yield return new PatternPart(pattern.Substring(position, pattern.Length - position));
    }

    private static PatternPart ValidatePart(PatternPart part)
    {
        switch (part.Type)
        {
            case PatternPartType.Date:
            {
                if (part.Format is not null && new DateTime(2020, 01, 01, 03, 04, 05, 06).TryFormat(stackalloc char[128], out _, part.Format, CultureInfo.InvariantCulture))
                    return part;

                return new PatternPart(PatternPartType.Date, "yyyy-MM-dd");
            }

            case PatternPartType.Time:
            {
                if (part.Format is not null && new TimeSpan(0, 01, 02, 03, 04).TryFormat(stackalloc char[128], out _, part.Format, CultureInfo.InvariantCulture))
                    return part;

                return new PatternPart(PatternPartType.Time, @"hh\:mm\:ss\.fffffff");
            }

            case PatternPartType.Level:
            {
                if (part.Format?.ToLowerInvariant() is "pad" or "padded")
                    return new PatternPart(PatternPartType.LevelPadded);

                return part;
            }
        }

        return part;
    }

    private static IEnumerable<PatternPart> OptimizeParts(IEnumerable<PatternPart> parts)
    {
        var currentString = string.Empty;

        foreach (var part in parts)
        {
            if (part.Type == PatternPartType.String)
            {
                currentString += part.Format;
            }
            else
            {
                if (currentString.Length != 0)
                {
                    yield return new PatternPart(currentString);
                    currentString = string.Empty;
                }

                yield return part;
            }
        }

        if (currentString.Length != 0)
            yield return new PatternPart(currentString);
    }

    [SuppressMessage("ReSharper", "ReplaceSliceWithRangeIndexer")]
    public void WritePrefix(LoggedMessage message, Span<char> destination, out int charsWritten)
    {
        var builder = new CharBufferBuilder(destination);

        foreach (var part in _parts)
        {
            switch (part.Type)
            {
                case PatternPartType.String:
                {
                    if (!builder.TryAppendPartial(part.Format))
                        goto endOfLoop;

                    break;
                }

                case PatternPartType.Date:
                {
                    if (!builder.TryAppend(message.Timestamp, part.Format))
                        goto endOfLoop;

                    break;
                }

                case PatternPartType.Time:
                {
                    if (!builder.TryAppend(message.Timestamp.TimeOfDay, part.Format))
                        goto endOfLoop;

                    break;
                }

                case PatternPartType.Thread:
                {
                    var thread = message.Thread;

                    if (thread != null)
                    {
                        if (thread.Name != null)
                        {
                            if (!builder.TryAppendPartial(thread.Name))
                                goto endOfLoop;
                        }
                        else
                        {
                            if (!builder.TryAppend(thread.ManagedThreadId))
                                goto endOfLoop;
                        }
                    }
                    else
                    {
                        if (!builder.TryAppend('0'))
                            goto endOfLoop;
                    }

                    break;
                }

                case PatternPartType.Level:
                {
                    var levelString = message.Level switch
                    {
                        LogLevel.Trace => "TRACE",
                        LogLevel.Debug => "DEBUG",
                        LogLevel.Info  => "INFO",
                        LogLevel.Warn  => "WARN",
                        LogLevel.Error => "ERROR",
                        LogLevel.Fatal => "FATAL",
                        _              => "???"
                    };

                    if (!builder.TryAppendWhole(levelString))
                        goto endOfLoop;

                    break;
                }

                case PatternPartType.LevelPadded:
                {
                    var levelString = message.Level switch
                    {
                        LogLevel.Trace => "TRACE",
                        LogLevel.Debug => "DEBUG",
                        LogLevel.Info  => "INFO ",
                        LogLevel.Warn  => "WARN ",
                        LogLevel.Error => "ERROR",
                        LogLevel.Fatal => "FATAL",
                        _              => "???  "
                    };

                    if (!builder.TryAppendWhole(levelString))
                        goto endOfLoop;

                    break;
                }

                case PatternPartType.Logger:
                {
                    if (!builder.TryAppendPartial(message.LoggerName))
                        goto endOfLoop;

                    break;
                }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        endOfLoop:

        charsWritten = builder.Length;
    }

    private enum PatternPartType
    {
        String,
        Date,
        Time,
        Thread,
        Level,
        LevelPadded,
        Logger
    }

    private readonly struct PatternPart
    {
        public PatternPartType Type { get; }
        public string? Format { get; }

        public PatternPart(PatternPartType type, string? format = null)
        {
            Type = type;
            Format = format;
        }

        public PatternPart(string value)
        {
            Type = PatternPartType.String;
            Format = value;
        }
    }
}
