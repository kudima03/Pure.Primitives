using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record MinDoubleTests
{
    [Fact]
    public void InitializeAsMinDouble()
    {
        INumber<double> primitive = new MinDouble();
        Assert.Equal(double.MinValue, primitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new MinDouble().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new MinDouble().ToString());
    }
}