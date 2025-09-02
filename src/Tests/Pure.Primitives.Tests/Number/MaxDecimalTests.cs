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
        _ = Assert.Throws<NotSupportedException>(() => new MaxDecimal().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new MaxDecimal().ToString());
    }
}
