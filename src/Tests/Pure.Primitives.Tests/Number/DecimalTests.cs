using Pure.Primitives.Abstractions.Number;
using Decimal = Pure.Primitives.Number.Decimal;

namespace Pure.Primitives.Tests.Number;

public sealed record DecimalTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
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