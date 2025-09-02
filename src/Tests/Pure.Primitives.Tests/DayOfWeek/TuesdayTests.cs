using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.DayOfWeek;

namespace Pure.Primitives.Tests.DayOfWeek;

public sealed record TuesdayTests
{
    [Fact]
    public void InitializeFromDefaultConstructor()
    {
        const int expectedValue = 2;
        IDayOfWeek dayOfWeek = new Tuesday();
        Assert.Equal(expectedValue, dayOfWeek.DayNumberValue.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new Tuesday().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new Tuesday().ToString());
    }
}
