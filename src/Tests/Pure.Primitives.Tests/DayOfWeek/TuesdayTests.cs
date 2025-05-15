using Pure.Primitives.DayOfWeek;

namespace Pure.Primitives.Tests.DayOfWeek;

public sealed record TuesdayTests
{
    [Fact]
    public void InitializeFromDefaultConstructor()
    {
        const int expectedValue = 2;
        IDayOfWeek dayOfWeek = new Tuesday();
        Assert.Equal(expectedValue, dayOfWeek.DayNumber.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Tuesday().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Tuesday().ToString());
    }
}