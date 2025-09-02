using Pure.Primitives.Abstractions.DateTime;

namespace Pure.Primitives.Tests.DateTime;

using Date = Primitives.Date.Date;
using DateTime = Primitives.DateTime.DateTime;
using Time = Primitives.Time.Time;

public sealed record DateTimeTests
{
    [Fact]
    public void InitializeFromIDateITime()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        TimeOnly timeOnly = new TimeOnly(15, 30, 30, 30, 30);

        IDateTime date = new DateTime(new Date(dateOnly), new Time(timeOnly));

        Assert.Equal(
            new System.DateTime(dateOnly, timeOnly),
            new System.DateTime(
                new DateOnly(
                    date.Year.NumberValue,
                    date.Month.NumberValue,
                    date.Day.NumberValue
                ),
                new TimeOnly(
                    date.Hour.NumberValue,
                    date.Minute.NumberValue,
                    date.Second.NumberValue,
                    date.Millisecond.NumberValue,
                    date.Microsecond.NumberValue
                )
            )
        );
    }

    [Fact]
    public void InitializeFromIDate()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        IDateTime date = new DateTime(new Date(dateOnly));

        Assert.Equal(
            dateOnly,
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
        _ = Assert.Throws<NotSupportedException>(() =>
            new DateTime(new Date(DateOnly.MaxValue)).GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new DateTime(new Date(DateOnly.MaxValue)).ToString()
        );
    }
}
