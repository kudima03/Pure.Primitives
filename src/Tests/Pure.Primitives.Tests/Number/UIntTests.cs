using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record UIntTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const uint testValue = 3910283761;
        IUInt uintPrimitive = new UInt(testValue);
        Assert.Equal(testValue, uintPrimitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new UInt(754514523).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new UInt(918023479).ToString());
    }
}