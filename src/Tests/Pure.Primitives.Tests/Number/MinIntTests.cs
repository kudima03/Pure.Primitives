using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MinIntTests
{
    [Fact]
    public void InitializeAsMinInt()
    {
        INumber<int> primitive = new MinInt();
        Assert.Equal(int.MinValue, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new MinInt().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new MinInt().ToString());
    }
}