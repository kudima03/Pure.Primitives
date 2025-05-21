using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.DayOfWeek;

namespace Pure.Primitives.Tests.DayOfWeek;

public sealed record MondayTests
{
    [Fact]
    public void InitializeFromDefaultConstructor()
    {
        const int expectedValue = 1;
        IDayOfWeek dayOfWeek = new Monday();
        Assert.Equal(expectedValue, dayOfWeek.DayNumber.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Monday().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Monday().ToString());
    }
}