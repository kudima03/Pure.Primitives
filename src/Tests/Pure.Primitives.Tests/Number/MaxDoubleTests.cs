using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MaxDoubleTests
{
    [Fact]
    public void InitializeAsMaxDouble()
    {
        INumber<double> primitive = new MaxDouble();
        Assert.Equal(double.MaxValue, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new MaxDouble().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new MaxDouble().ToString());
    }
}