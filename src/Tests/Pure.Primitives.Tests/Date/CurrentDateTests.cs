using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Date;

namespace Pure.Primitives.Tests.Date;

public sealed record CurrentDateTests
{
    [Fact]
    public void InitializeCorrectly()
    {
        IDate date = new CurrentDate();

        Assert.Equal(
            DateOnly.FromDateTime(System.DateTime.Today),
            new DateOnly(
                date.Year.NumberValue,
                date.Month.NumberValue,
                date.Day.NumberValue
            )
        );
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new CurrentDate().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new CurrentDate().ToString());
    }
}
