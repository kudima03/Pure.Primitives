using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Time;

using Time = Primitives.Time.Time;

public sealed record TimeTests
{
    [Fact]
    public void ThrowsExceptionOnInvalidHours()
    {
        ITime time = new Time(new UShort(24), new UShort(10));

        _ = Assert.Throws<ArgumentException>(() => time.Hour);
        _ = Assert.Throws<ArgumentException>(() => time.Minute);
        _ = Assert.Throws<ArgumentException>(() => time.Second);
        _ = Assert.Throws<ArgumentException>(() => time.Millisecond);
        _ = Assert.Throws<ArgumentException>(() => time.Microsecond);
        _ = Assert.Throws<ArgumentException>(() => time.Nanosecond);
    }

    [Fact]
    public void ThrowsExceptionOnInvalidMinutes()
    {
        ITime time = new Time(new UShort(23), new UShort(60));

        _ = Assert.Throws<ArgumentException>(() => time.Hour);
        _ = Assert.Throws<ArgumentException>(() => time.Minute);
        _ = Assert.Throws<ArgumentException>(() => time.Second);
        _ = Assert.Throws<ArgumentException>(() => time.Millisecond);
        _ = Assert.Throws<ArgumentException>(() => time.Microsecond);
        _ = Assert.Throws<ArgumentException>(() => time.Nanosecond);
    }

    [Fact]
    public void ThrowsExceptionOnInvalidSeconds()
    {
        ITime time = new Time(new UShort(23), new UShort(59), new UShort(60));

        _ = Assert.Throws<ArgumentException>(() => time.Hour);
        _ = Assert.Throws<ArgumentException>(() => time.Minute);
        _ = Assert.Throws<ArgumentException>(() => time.Second);
        _ = Assert.Throws<ArgumentException>(() => time.Millisecond);
        _ = Assert.Throws<ArgumentException>(() => time.Microsecond);
        _ = Assert.Throws<ArgumentException>(() => time.Nanosecond);
    }

    [Fact]
    public void ThrowsExceptionOnInvalidMilliseconds()
    {
        ITime time = new Time(
            new UShort(23),
            new UShort(59),
            new UShort(59),
            new UShort(1000)
        );

        _ = Assert.Throws<ArgumentException>(() => time.Hour);
        _ = Assert.Throws<ArgumentException>(() => time.Minute);
        _ = Assert.Throws<ArgumentException>(() => time.Second);
        _ = Assert.Throws<ArgumentException>(() => time.Millisecond);
        _ = Assert.Throws<ArgumentException>(() => time.Microsecond);
        _ = Assert.Throws<ArgumentException>(() => time.Nanosecond);
    }

    [Fact]
    public void ThrowsExceptionOnInvalidMicroseconds()
    {
        ITime time = new Time(
            new UShort(23),
            new UShort(59),
            new UShort(59),
            new UShort(999),
            new UShort(1000)
        );

        _ = Assert.Throws<ArgumentException>(() => time.Hour);
        _ = Assert.Throws<ArgumentException>(() => time.Minute);
        _ = Assert.Throws<ArgumentException>(() => time.Second);
        _ = Assert.Throws<ArgumentException>(() => time.Millisecond);
        _ = Assert.Throws<ArgumentException>(() => time.Microsecond);
        _ = Assert.Throws<ArgumentException>(() => time.Nanosecond);
    }

    [Fact]
    public void ThrowsExceptionOnInvalidNanoseconds()
    {
        ITime time = new Time(
            new UShort(23),
            new UShort(59),
            new UShort(59),
            new UShort(999),
            new UShort(999),
            new UShort(1000)
        );

        _ = Assert.Throws<ArgumentException>(() => time.Hour);
        _ = Assert.Throws<ArgumentException>(() => time.Minute);
        _ = Assert.Throws<ArgumentException>(() => time.Second);
        _ = Assert.Throws<ArgumentException>(() => time.Millisecond);
        _ = Assert.Throws<ArgumentException>(() => time.Microsecond);
        _ = Assert.Throws<ArgumentException>(() => time.Nanosecond);
    }

    [Fact]
    public void InitializeFromTimeOnly()
    {
        TimeOnly timeOnly = new TimeOnly(15, 31, 32, 33, 34);

        ITime time = new Time(timeOnly);

        Assert.Equal(
            timeOnly,
            new TimeOnly(
                time.Hour.NumberValue,
                time.Minute.NumberValue,
                time.Second.NumberValue,
                time.Millisecond.NumberValue,
                time.Microsecond.NumberValue
            )
        );

        Assert.Equal(timeOnly.Nanosecond, time.Nanosecond.NumberValue);
    }

    [Fact]
    public void InitializeFromFullNumbers()
    {
        TimeOnly timeOnly = new TimeOnly(15, 31, 32, 33, 34);

        ITime time = new Time(
            new UShort((ushort)timeOnly.Hour),
            new UShort((ushort)timeOnly.Minute),
            new UShort((ushort)timeOnly.Second),
            new UShort((ushort)timeOnly.Millisecond),
            new UShort((ushort)timeOnly.Microsecond),
            new UShort((ushort)timeOnly.Nanosecond)
        );

        Assert.Equal(
            timeOnly,
            new TimeOnly(
                time.Hour.NumberValue,
                time.Minute.NumberValue,
                time.Second.NumberValue,
                time.Millisecond.NumberValue,
                time.Microsecond.NumberValue
            )
        );

        Assert.Equal(timeOnly.Nanosecond, time.Nanosecond.NumberValue);
    }

    [Fact]
    public void InitializeFromNumbers()
    {
        TimeOnly timeOnly = new TimeOnly(15, 31, 32);

        ITime time = new Time(
            new UShort((ushort)timeOnly.Hour),
            new UShort((ushort)timeOnly.Minute),
            new UShort((ushort)timeOnly.Second)
        );

        Assert.Equal(
            timeOnly,
            new TimeOnly(
                time.Hour.NumberValue,
                time.Minute.NumberValue,
                time.Second.NumberValue
            )
        );
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new Time(new UShort(1), new UShort(1), new UShort(2000)).GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new Time(new UShort(1), new UShort(1), new UShort(2000)).ToString()
        );
    }
}
