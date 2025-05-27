using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MinUshortTests
{
    [Fact]
    public void InitializeAsMinInt()
    {
        INumber<ushort> primitive = new MinUshort();
        Assert.Equal(ushort.MinValue, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new MinUshort().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new MinUshort().ToString());
    }
}