using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool;

namespace Pure.Primitives.Tests.Bool;

public sealed record TrueTests
{
    [Fact]
    public void InitializeFromDefaultConstructor()
    {
        IBool trueValue = new True();
        Assert.True(trueValue.BoolValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new True().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new True().ToString());
    }
}
