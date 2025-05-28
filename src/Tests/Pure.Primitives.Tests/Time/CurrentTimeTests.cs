using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Time;

namespace Pure.Primitives.Tests.Time;

public sealed record CurrentTimeTests
{
    [Fact]
    public void InitializeCorrectly()
    {
        TimeOnly time = new TimeOnly(System.DateTime.Now.Hour,
            System.DateTime.Now.Minute,
            System.DateTime.Now.Second);

        ITime currentTime = new CurrentTime();

        Assert.Equal(time,
            new TimeOnly(currentTime.Hour.NumberValue,
                currentTime.Minute.NumberValue,
                currentTime.Second.NumberValue));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new CurrentTime().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new CurrentTime().ToString());
    }
}