using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MaxIntTests
{
    [Fact]
    public void InitializeAsMaxInt()
    {
        INumber<int> primitive = new MaxInt();
        Assert.Equal(int.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new MaxInt().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new MaxInt().ToString());
    }
}
