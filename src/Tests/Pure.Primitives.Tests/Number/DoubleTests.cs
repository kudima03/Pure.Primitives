using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

using Double = Primitives.Number.Double;

public sealed record DoubleTests
{
    [Fact]
    public void InitializeFromUShortConstructor()
    {
        INumber<double> doublePrimitive = new Double(new MaxUshort());
        Assert.Equal(ushort.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromFloatConstructor()
    {
        INumber<double> doublePrimitive = new Double(new MaxFloat());
        Assert.Equal(float.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromUlongConstructor()
    {
        INumber<double> doublePrimitive = new Double(new MaxUlong());
        Assert.Equal(ulong.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromShortConstructor()
    {
        INumber<double> doublePrimitive = new Double(new MaxShort());
        Assert.Equal(short.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromIntConstructor()
    {
        INumber<double> doublePrimitive = new Double(new MaxInt());
        Assert.Equal(int.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromUIntConstructor()
    {
        INumber<double> doublePrimitive = new Double(new MaxUint());
        Assert.Equal(uint.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromLongConstructor()
    {
        INumber<double> doublePrimitive = new Double(new MaxLong());
        Assert.Equal(long.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromDecimalConstructor()
    {
        INumber<double> doublePrimitive = new Double(new MaxDecimal());
        Assert.Equal(Convert.ToDouble(decimal.MaxValue), doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromDoubleConstructor()
    {
        const double testValue = 1.12837491280374129387591229837529183759012;
        INumber<double> doublePrimitive = new Double(testValue);
        Assert.Equal(testValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() =>
            new Double(0.187946582364598632987465).GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() =>
            new Double(0.9876123479612978365971267).ToString()
        );
    }
}