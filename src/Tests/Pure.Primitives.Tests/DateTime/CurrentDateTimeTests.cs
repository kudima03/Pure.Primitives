using Pure.Primitives.Abstractions.DateTime;
using Pure.Primitives.DateTime;

namespace Pure.Primitives.Tests.DateTime;

public sealed record CurrentDateTimeTests
{
    [Fact]
    public void InitializeCorrectly()
    {
        IDateTime date = new CurrentDateTime();

        Assert.Equal(
            System.DateTime.Parse(System.DateTime.Now.ToString("s")),
            new System.DateTime(
                new DateOnly(date.Year.NumberValue, date.Month.NumberValue, date.Day.NumberValue),
                new TimeOnly(
                    date.Hour.NumberValue,
                    date.Minute.NumberValue,
                    date.Second.NumberValue
                )
            )
        );
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new CurrentDateTime().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new CurrentDateTime().ToString());
    }
}