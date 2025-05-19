using Pure.Primitives.Number.Base;

namespace Pure.Primitives.Tests.Number;

using Double = Primitives.Number.Double;

public sealed record DoubleTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const double testValue = 1.12837491280374129387591229837529183759012;
        INumber<double> doublePrimitive = new Double(testValue);
        Assert.Equal(testValue, doublePrimitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Double(0.187946582364598632987465).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Double(0.9876123479612978365971267).ToString());
    }
}