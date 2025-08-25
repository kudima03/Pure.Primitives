using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MaxUlongTests
{
    [Fact]
    public void InitializeAsMaxUlong()
    {
        INumber<ulong> primitive = new MaxUlong();
        Assert.Equal(ulong.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new MaxUlong().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new MaxUlong().ToString());
    }
}