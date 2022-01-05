//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

namespace ZeroLog;

#nullable enable

partial class LogMessage
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(bool value)
    {
        InternalAppendValueType(value, ArgumentType.Boolean);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(bool? value)
    {
        InternalAppendValueType(value, ArgumentType.Boolean);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, bool value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Boolean);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, bool? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Boolean);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(byte value)
    {
        InternalAppendValueType(value, ArgumentType.Byte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(byte? value)
    {
        InternalAppendValueType(value, ArgumentType.Byte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(byte value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Byte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(byte? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Byte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, byte value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Byte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, byte? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Byte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(sbyte value)
    {
        InternalAppendValueType(value, ArgumentType.SByte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(sbyte? value)
    {
        InternalAppendValueType(value, ArgumentType.SByte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(sbyte value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.SByte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(sbyte? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.SByte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, sbyte value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.SByte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, sbyte? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.SByte);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(char value)
    {
        InternalAppendValueType(value, ArgumentType.Char);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(char? value)
    {
        InternalAppendValueType(value, ArgumentType.Char);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, char value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Char);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, char? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Char);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(short value)
    {
        InternalAppendValueType(value, ArgumentType.Int16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(short? value)
    {
        InternalAppendValueType(value, ArgumentType.Int16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(short value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Int16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(short? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Int16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, short value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Int16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, short? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Int16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(ushort value)
    {
        InternalAppendValueType(value, ArgumentType.UInt16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(ushort? value)
    {
        InternalAppendValueType(value, ArgumentType.UInt16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(ushort value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.UInt16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(ushort? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.UInt16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, ushort value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.UInt16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, ushort? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.UInt16);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(int value)
    {
        InternalAppendValueType(value, ArgumentType.Int32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(int? value)
    {
        InternalAppendValueType(value, ArgumentType.Int32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(int value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Int32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(int? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Int32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, int value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Int32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, int? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Int32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(uint value)
    {
        InternalAppendValueType(value, ArgumentType.UInt32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(uint? value)
    {
        InternalAppendValueType(value, ArgumentType.UInt32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(uint value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.UInt32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(uint? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.UInt32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, uint value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.UInt32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, uint? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.UInt32);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(long value)
    {
        InternalAppendValueType(value, ArgumentType.Int64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(long? value)
    {
        InternalAppendValueType(value, ArgumentType.Int64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(long value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Int64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(long? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Int64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, long value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Int64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, long? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Int64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(ulong value)
    {
        InternalAppendValueType(value, ArgumentType.UInt64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(ulong? value)
    {
        InternalAppendValueType(value, ArgumentType.UInt64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(ulong value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.UInt64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(ulong? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.UInt64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, ulong value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.UInt64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, ulong? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.UInt64);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(nint value)
    {
        InternalAppendValueType(value, ArgumentType.IntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(nint? value)
    {
        InternalAppendValueType(value, ArgumentType.IntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(nint value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.IntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(nint? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.IntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, nint value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.IntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, nint? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.IntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(nuint value)
    {
        InternalAppendValueType(value, ArgumentType.UIntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(nuint? value)
    {
        InternalAppendValueType(value, ArgumentType.UIntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(nuint value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.UIntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(nuint? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.UIntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, nuint value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.UIntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, nuint? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.UIntPtr);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(float value)
    {
        InternalAppendValueType(value, ArgumentType.Single);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(float? value)
    {
        InternalAppendValueType(value, ArgumentType.Single);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(float value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Single);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(float? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Single);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, float value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Single);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, float? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Single);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(double value)
    {
        InternalAppendValueType(value, ArgumentType.Double);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(double? value)
    {
        InternalAppendValueType(value, ArgumentType.Double);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(double value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Double);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(double? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Double);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, double value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Double);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, double? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Double);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(decimal value)
    {
        InternalAppendValueType(value, ArgumentType.Decimal);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(decimal? value)
    {
        InternalAppendValueType(value, ArgumentType.Decimal);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(decimal value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Decimal);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(decimal? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Decimal);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, decimal value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Decimal);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, decimal? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Decimal);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(Guid value)
    {
        InternalAppendValueType(value, ArgumentType.Guid);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(Guid? value)
    {
        InternalAppendValueType(value, ArgumentType.Guid);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(Guid value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Guid);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(Guid? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.Guid);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, Guid value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Guid);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, Guid? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.Guid);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(DateTime value)
    {
        InternalAppendValueType(value, ArgumentType.DateTime);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(DateTime? value)
    {
        InternalAppendValueType(value, ArgumentType.DateTime);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(DateTime value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.DateTime);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(DateTime? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.DateTime);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, DateTime value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.DateTime);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, DateTime? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.DateTime);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(TimeSpan value)
    {
        InternalAppendValueType(value, ArgumentType.TimeSpan);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(TimeSpan? value)
    {
        InternalAppendValueType(value, ArgumentType.TimeSpan);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(TimeSpan value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.TimeSpan);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage Append(TimeSpan? value, string format)
    {
        InternalAppendValueType(value, format, ArgumentType.TimeSpan);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, TimeSpan value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.TimeSpan);
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LogMessage AppendKeyValue(string key, TimeSpan? value)
    {
        InternalAppendKeyValue(key, value, ArgumentType.TimeSpan);
        return this;
    }

}
