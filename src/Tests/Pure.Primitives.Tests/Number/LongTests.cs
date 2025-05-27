using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record LongTests
{
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