using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.Time;

public sealed record Time : ITime
{
    private readonly INumber<ushort> _hour;
    private readonly INumber<ushort> _minute;
    private readonly INumber<ushort> _second;
    private readonly INumber<ushort> _millisecond;
    private readonly INumber<ushort> _microsecond;

    public Time(INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second) :
        this(hour, minute, second, new UShort(0), new UShort(0))
    { }

    public Time(TimeOnly timeOnly) : this(
        new UShort((ushort)timeOnly.Hour),
        new UShort((ushort)timeOnly.Minute),
        new UShort((ushort)timeOnly.Second),
        new UShort((ushort)timeOnly.Millisecond),
        new UShort((ushort)timeOnly.Microsecond))
    { }

    public Time(INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second,
        INumber<ushort> millisecond,
        INumber<ushort> microsecond)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
        _microsecond = microsecond;
    }

    TimeOnly ITime.TimeValue => new TimeOnly(_hour.NumberValue,
        _minute.NumberValue,
        _second.NumberValue,
        _millisecond.NumberValue,
        _microsecond.NumberValue);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}