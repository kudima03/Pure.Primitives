using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record UIntTests
{
    [Fact]
    public void InitializeFromUShortConstructor()
    {
        INumber<uint> primitive = new UInt(new MaxUshort());
        Assert.Equal(ushort.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const uint testValue = 3910283761;
        INumber<uint> uintPrimitive = new UInt(testValue);
        Assert.Equal(testValue, uintPrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new UInt(754514523).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new UInt(918023479).ToString());
    }
}
