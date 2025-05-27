using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MaxUshortTests
{
    [Fact]
    public void InitializeAsMinInt()
    {
        INumber<ushort> primitive = new MaxUshort();
        Assert.Equal(ushort.MaxValue, primitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new MaxUshort().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new MaxUshort().ToString());
    }
}