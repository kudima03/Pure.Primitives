using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MaxUintTests
{
    [Fact]
    public void InitializeAsMaxUint()
    {
        INumber<uint> primitive = new MaxUint();
        Assert.Equal(long.MinValue, primitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new MaxUint().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new MaxUint().ToString());
    }
}