using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Time;

using Time = Primitives.Time.Time;

public sealed record TimeTests
{
    [Fact]
    public void InitializeFromTimeOnly()
    {
        TimeOnly timeOnly = new TimeOnly(15, 31, 32, 33, 34);

        ITime time = new Time(timeOnly);

        Assert.Equal(timeOnly,
            new TimeOnly(time.Hour.NumberValue,
                time.Minute.NumberValue,
                time.Second.NumberValue,
                time.Millisecond.NumberValue,
                time.Microsecond.NumberValue));
    }

    [Fact]
    public void InitializeFromFullNumbers()
    {
        TimeOnly timeOnly = new TimeOnly(15, 31, 32, 33, 34);

        ITime time = new Time(new UShort((ushort)timeOnly.Hour),
            new UShort((ushort)timeOnly.Minute),
            new UShort((ushort)timeOnly.Second),
            new UShort((ushort)timeOnly.Millisecond),
            new UShort((ushort)timeOnly.Microsecond));

        Assert.Equal(timeOnly, new TimeOnly(time.Hour.NumberValue,
            time.Minute.NumberValue,
            time.Second.NumberValue,
            time.Millisecond.NumberValue,
            time.Microsecond.NumberValue));
    }

    [Fact]
    public void InitializeFromNumbers()
    {
        TimeOnly timeOnly = new TimeOnly(15, 31, 32);

        ITime time = new Time(new UShort((ushort)timeOnly.Hour),
            new UShort((ushort)timeOnly.Minute),
            new UShort((ushort)timeOnly.Second));

        Assert.Equal(timeOnly, new TimeOnly(time.Hour.NumberValue,
            time.Minute.NumberValue,
            time.Second.NumberValue));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() =>
            new Time(new UShort(1), new UShort(1), new UShort(2000)).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() =>
            new Time(new UShort(1), new UShort(1), new UShort(2000)).ToString());
    }
}