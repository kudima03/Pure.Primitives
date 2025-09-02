using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record ULongTests
{
    [Fact]
    public void InitializeFromUShortConstructor()
    {
        INumber<ulong> primitive = new ULong(new MaxUshort());
        Assert.Equal(ushort.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromUIntConstructor()
    {
        INumber<ulong> primitive = new ULong(new MaxUint());
        Assert.Equal(uint.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const ulong testValue = 1910283761123132897;
        INumber<ulong> doublePrimitive = new ULong(testValue);
        Assert.Equal(testValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new ULong(ulong.MaxValue).GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new ULong(ulong.MaxValue).ToString()
        );
    }
}
