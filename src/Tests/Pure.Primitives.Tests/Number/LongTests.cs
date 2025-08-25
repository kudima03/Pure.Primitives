using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record LongTests
{
    [Fact]
    public void InitializeFromShortConstructor()
    {
        INumber<long> primitive = new Long(new MaxShort());
        Assert.Equal(short.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromUShortConstructor()
    {
        INumber<long> primitive = new Long(new MaxUshort());
        Assert.Equal(ushort.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromIntConstructor()
    {
        INumber<long> primitive = new Long(new MaxInt());
        Assert.Equal(int.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromUIntConstructor()
    {
        INumber<long> primitive = new Long(new MaxUint());
        Assert.Equal(uint.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const long testValue = 1910283761123132897;
        INumber<long> doublePrimitive = new Long(testValue);
        Assert.Equal(testValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Long(18459863293736745).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Long(36597126725373475).ToString());
    }
}