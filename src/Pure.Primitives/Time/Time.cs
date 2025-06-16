using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.Time;

public sealed record Time : ITime
{
    public Time(TimeOnly timeOnly) : this(
        new UShort((ushort)timeOnly.Hour),
        new UShort((ushort)timeOnly.Minute),
        new UShort((ushort)timeOnly.Second),
        new UShort((ushort)timeOnly.Millisecond),
        new UShort((ushort)timeOnly.Microsecond),
        new UShort((ushort)timeOnly.Nanosecond))
    { }

    public Time(INumber<ushort> hour,
        INumber<ushort> minute) :
        this(hour,
            minute, 
            new Zero<ushort>())
    { }

    public Time(INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second) :
        this(hour, 
            minute, 
            second, 
            new Zero<ushort>())
    { }

    public Time(INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second,
        INumber<ushort> millisecond) :
        this(hour,
            minute, 
            second, 
            millisecond,
            new Zero<ushort>())
    { }

    public Time(INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second,
        INumber<ushort> millisecond,
        INumber<ushort> microsecond) :
        this(hour, 
            minute, 
            second, 
            millisecond, 
            microsecond, 
            new Zero<ushort>())
    { }

    public Time(INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second,
        INumber<ushort> millisecond,
        INumber<ushort> microsecond,
        INumber<ushort> nanosecond)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
        Microsecond = microsecond;
        Nanosecond = nanosecond;
    }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }

    public INumber<ushort> Hour { get; }

    public INumber<ushort> Minute { get; }

    public INumber<ushort> Second { get; }

    public INumber<ushort> Millisecond { get; }

    public INumber<ushort> Microsecond { get; }

    public INumber<ushort> Nanosecond { get; }
}