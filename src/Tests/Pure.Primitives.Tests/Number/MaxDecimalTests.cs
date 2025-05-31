using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MaxDecimalTests
{
    [Fact]
    public void InitializeAsMaxDecimal()
    {
        INumber<decimal> primitive = new MaxDecimal();
        Assert.Equal(decimal.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new MaxDouble().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new MaxDouble().ToString());
    }
}