using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.DayOfWeek;

namespace Pure.Primitives.Tests.DayOfWeek;

public sealed record SundayTests
{
    [Fact]
    public void InitializeFromDefaultConstructor()
    {
        const int expectedValue = 7;
        IDayOfWeek dayOfWeek = new Sunday();
        Assert.Equal(expectedValue, dayOfWeek.DayNumber.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Sunday().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Sunday().ToString());
    }
}