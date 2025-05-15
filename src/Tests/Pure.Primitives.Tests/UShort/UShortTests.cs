using Pure.Primitives.String;
using Pure.Primitives.UShort;

namespace Pure.Primitives.Tests.UShort;

using UShort = Primitives.UShort.UShort;

public sealed record UShortTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const ushort testValue = 11324;
        IUShort ushortPrimitive = new UShort(testValue);
        Assert.Equal(testValue, ushortPrimitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new UShort(8789).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new UShort(56478).ToString());
    }
}