using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.DayOfWeek;

namespace Pure.Primitives.Tests.DayOfWeek;

public sealed record FridayTests
{
    [Fact]
    public void InitializeFromDefaultConstructor()
    {
        const int expectedValue = 5;
        IDayOfWeek dayOfWeek = new Friday();
        Assert.Equal(expectedValue, dayOfWeek.DayNumberValue.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Friday().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Friday().ToString());
    }
}