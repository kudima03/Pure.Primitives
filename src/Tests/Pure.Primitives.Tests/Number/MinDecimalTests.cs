using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MinDecimalTests
{
    [Fact]
    public void InitializeAsMinDecimal()
    {
        INumber<decimal> primitive = new MinDecimal();
        Assert.Equal(decimal.MinValue, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new MinDecimal().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new MinDecimal().ToString());
    }
}
