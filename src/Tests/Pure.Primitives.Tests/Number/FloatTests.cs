using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record FloatTests
{
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