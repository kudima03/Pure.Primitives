using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MaxUintTests
{
    [Fact]
    public void InitializeAsMaxUint()
    {
        INumber<uint> primitive = new MaxUint();
        Assert.Equal(uint.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new MaxUint().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new MaxUint().ToString());
    }
}
