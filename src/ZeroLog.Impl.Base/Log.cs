﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ZeroLog;

public sealed partial class Log
{
    [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
    private Level _logLevel;

    internal string Name { get; }

    internal Log(string name)
    {
        Name = name;

#if NETSTANDARD
        _logLevel = Level.Fatal;
#endif
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public partial bool IsEnabled(Level level);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public partial LogMessage ForLevel(Level level);

#if NETSTANDARD

    public partial bool IsEnabled(Level level)
        => false;

    public partial LogMessage ForLevel(Level level)
        => LogMessage.Empty;

#endif
}
