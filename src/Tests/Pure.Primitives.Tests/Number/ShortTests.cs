using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record ShortTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const short testValue = 11324;
        INumber<short> ushortPrimitive = new Short(testValue);
        Assert.Equal(testValue, ushortPrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Short(8789).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Short(short.MinValue).ToString());
    }
}