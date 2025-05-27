using Pure.Primitives.Abstractions.DateTime;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.DateTime;

using Date = Primitives.Date.Date;
using DateTime = Primitives.DateTime.DateTime;
using Time = Primitives.Time.Time;

public sealed record DateTimeTests
{
    [Fact]
    public void InitializeFromDateOnlyTimeOnly()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        TimeOnly timeOnly = new TimeOnly(15, 30, 30, 30, 30);

        IDateTime date = new DateTime(dateOnly, timeOnly);

        Assert.Equal(dateOnly, date.DateValue);
    }

    [Fact]
    public void InitializeFromDateOnly()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        IDateTime date = new DateTime(dateOnly);

        Assert.Equal(dateOnly, date.DateValue);
    }

    [Fact]
    public void InitializeFromIDateITime()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        TimeOnly timeOnly = new TimeOnly(15, 30, 30, 30, 30);

        IDateTime date = new DateTime(new Date(dateOnly), new Time(timeOnly));

        Assert.Equal(
            new System.DateTime(dateOnly, timeOnly),
            new System.DateTime(date.DateValue, date.TimeValue));
    }

    [Fact]
    public void InitializeFromIDate()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        IDateTime date = new DateTime(new Date(dateOnly));

        Assert.Equal(dateOnly, date.DateValue);
    }

    [Fact]
    public void InitializeFromNumbers()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        TimeOnly timeOnly = new TimeOnly(15, 30, 30, 30, 30);

        IDateTime date = new DateTime(
            new UShort((ushort)dateOnly.Day),
            new UShort((ushort)dateOnly.Month),
            new UShort((ushort)dateOnly.Year),
            new UShort((ushort)timeOnly.Hour),
            new UShort((ushort)timeOnly.Minute),
            new UShort((ushort)timeOnly.Second),
            new UShort((ushort)timeOnly.Millisecond),
            new UShort((ushort)timeOnly.Microsecond));

        Assert.Equal(
            new System.DateTime(dateOnly, timeOnly),
            new System.DateTime(date.DateValue, date.TimeValue));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new DateTime(DateOnly.MaxValue).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new DateTime(DateOnly.MaxValue).ToString());
    }
}