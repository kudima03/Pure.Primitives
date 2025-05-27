using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Date;

using Date = Primitives.Date.Date;

public sealed record DateTests
{
    [Fact]
    public void InitializeFromDateOnly()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        IDate date = new Date(dateOnly);

        Assert.Equal(dateOnly, date.DateValue);
    } 

    [Fact]
    public void InitializeFromNumbers()
    {
        DateOnly dateOnly = new DateOnly(2000, 1, 1);

        IDate date = new Date(
            new UShort((ushort)dateOnly.Day),
            new UShort((ushort)dateOnly.Month),
            new UShort((ushort)dateOnly.Year));

        Assert.Equal(dateOnly, date.DateValue);
    } 
    
    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() =>
            new Date(new UShort(1), new UShort(1), new UShort(2000)).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => 
            new Date(new UShort(1), new UShort(1), new UShort(2000)).ToString());
    }
}