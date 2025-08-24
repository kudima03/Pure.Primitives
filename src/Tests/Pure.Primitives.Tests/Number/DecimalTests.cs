using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;
using Decimal = Pure.Primitives.Number.Decimal;

namespace Pure.Primitives.Tests.Number;

public sealed record DecimalTests
{
    [Fact]
    public void InitializeFromShortConstructor()
    {
        INumber<decimal> doublePrimitive = new Decimal(new Int(short.MaxValue));
        Assert.Equal(short.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromUShortConstructor()
    {
        INumber<decimal> doublePrimitive = new Decimal(new Int(ushort.MaxValue));
        Assert.Equal(ushort.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromIntConstructor()
    {
        INumber<decimal> doublePrimitive = new Decimal(new Int(int.MaxValue));
        Assert.Equal(int.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromUIntConstructor()
    {
        INumber<decimal> doublePrimitive = new Decimal(new UInt(uint.MaxValue));
        Assert.Equal(uint.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromLongConstructor()
    {
        INumber<decimal> doublePrimitive = new Decimal(new Long(long.MaxValue));
        Assert.Equal(long.MaxValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void InitializeFromDecimalConstructor()
    {
        INumber<decimal> doublePrimitive = new Decimal(0.1M + 0.2M);
        Assert.Equal(0.3M, doublePrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() =>
            new Decimal(0.187946582364598632987465M).GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() =>
            new Decimal(0.9876123479612978365971267M).ToString()
        );
    }
}