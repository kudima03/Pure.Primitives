using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record FloatTests
{
    [Fact]
    public void InitializeFromShortConstructor()
    {
        INumber<float> primitive = new Float(new MaxUshort());
        Assert.Equal(ushort.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromUShortConstructor()
    {
        INumber<float> primitive = new Float(new Int(ushort.MaxValue));
        Assert.Equal(ushort.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromIntConstructor()
    {
        INumber<float> primitive = new Float(new MaxInt());
        Assert.Equal(int.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromUIntConstructor()
    {
        INumber<float> primitive = new Float(new MaxUint());
        Assert.Equal(uint.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromLongConstructor()
    {
        INumber<float> primitive = new Float(new MaxLong());
        Assert.Equal(long.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const float testValue = 1.12837491280374129387837529183759012F;
        INumber<float> doublePrimitive = new Float(testValue);
        Assert.Equal(testValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() =>
            new Float(0.187946582364598632987465F).GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() =>
            new Float(0.9876123479612978365971267F).ToString()
        );
    }
}