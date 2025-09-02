using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool;

namespace Pure.Primitives.Tests.Bool;

public sealed record FalseTests
{
    [Fact]
    public void InitializeFromDefaultConstructor()
    {
        IBool trueValue = new False();
        Assert.False(trueValue.BoolValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new False().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new False().ToString());
    }
}
