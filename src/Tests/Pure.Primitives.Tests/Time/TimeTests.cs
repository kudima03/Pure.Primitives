using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Time;

using Time = Primitives.Time.Time;

public sealed record TimeTests
{
    [Fact]
    public void InitializeFromTimeOnly()
    {
        TimeOnly timeOnly = new TimeOnly(15, 30, 30, 30, 30);

        ITime time = new Time(timeOnly);

        Assert.Equal(timeOnly, time.TimeValue);
    }

    [Fact]
    public void InitializeFromFullNumbers()
    {
        TimeOnly timeOnly = new TimeOnly(15, 30, 30, 30, 30);

        ITime time = new Time(timeOnly);

        Assert.Equal(timeOnly, time.TimeValue);
    }

    [Fact]
    public void InitializeFromNumbers()
    {
        TimeOnly timeOnly = new TimeOnly(15, 30, 30);

        ITime time = new Time(timeOnly);

        Assert.Equal(timeOnly, time.TimeValue);
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