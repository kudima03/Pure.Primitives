using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Date;

using Date = Primitives.Date.Date;

public sealed record DateTests
{
    [Fact]
    public void ThrowsExceptionOnInvalidDay()
    {
        IDate date = new Date(new MaxUshort(), new UShort(1), new UShort(2000));
        _ = Assert.Throws<ArgumentException>(() => date.Year);
        _ = Assert.Throws<ArgumentException>(() => date.Month);
        _ = Assert.Throws<ArgumentException>(() => date.Day);
    }

    [Fact]
    public void ThrowsExceptionOnInvalidMonth()
    {
        IDate date = new Date(new UShort(1), new MaxUshort(), new UShort(2000));
        _ = Assert.Throws<ArgumentException>(() => date.Year);
        _ = Assert.Throws<ArgumentException>(() => date.Month);
        _ = Assert.Throws<ArgumentException>(() => date.Day);
    }

    [Fact]
    public void ThrowsExceptionOnInvalidYear()
    {
        IDate date = new Date(new UShort(1), new UShort(1), new MaxUshort());
        _ = Assert.Throws<ArgumentException>(() => date.Year);
        _ = Assert.Throws<ArgumentException>(() => date.Month);
        _ = Assert.Throws<ArgumentException>(() => date.Day);
    }

    [Fact]
    public void InitializeFromDateOnly()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        IDate date = new Date(dateOnly);

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
    public void InitializeFromNumbers()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        IDate date = new Date(
            new UShort((ushort)dateOnly.Day),
            new UShort((ushort)dateOnly.Month),
            new UShort((ushort)dateOnly.Year)
        );

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
            new Date(new UShort(1), new UShort(1), new UShort(2000)).GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new Date(new UShort(1), new UShort(1), new UShort(2000)).ToString()
        );
    }
}
