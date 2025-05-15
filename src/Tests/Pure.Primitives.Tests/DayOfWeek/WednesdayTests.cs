using Pure.Primitives.DayOfWeek;

namespace Pure.Primitives.Tests.DayOfWeek;

public sealed record WednesdayTests
{
    [Fact]
    public void InitializeFromDefaultConstructor()
    {
        const int expectedValue = 3;
        IDayOfWeek dayOfWeek = new Wednesday();
        Assert.Equal(expectedValue, dayOfWeek.DayNumber.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Wednesday().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Wednesday().ToString());
    }
}