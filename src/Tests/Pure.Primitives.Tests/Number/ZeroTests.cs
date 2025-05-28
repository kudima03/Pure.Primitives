using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record ZeroTests
{
    [Fact]
    public void ReturnsCorrectZeroUint()
    {
        INumber<uint> primitive = new Zero<uint>();
        Assert.Equal((uint)0, primitive.NumberValue);
    }
    [Fact]
    public void ReturnsCorrectZeroDouble()
    {
        INumber<double> primitive = new Zero<double>();
        Assert.Equal(0, primitive.NumberValue);
    }
    [Fact]
    public void ReturnsCorrectZeroFloat()
    {
        INumber<float> primitive = new Zero<float>();
        Assert.Equal(0, primitive.NumberValue);
    }
    [Fact]
    public void ReturnsCorrectZeroUShort()
    {
        INumber<ushort> primitive = new Zero<ushort>();
        Assert.Equal((ushort)0, primitive.NumberValue);
    }
    [Fact]
    public void ReturnsCorrectZeroInt()
    {
        INumber<int> primitive = new Zero<int>();
        Assert.Equal(0, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Zero<uint>().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Zero<long>().ToString());
    }
}