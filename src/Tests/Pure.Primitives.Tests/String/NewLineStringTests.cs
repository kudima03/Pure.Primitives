using Pure.Primitives.Abstractions.String;
using Pure.Primitives.String;

namespace Pure.Primitives.Tests.String;

public sealed record NewLineStringTests
{
    [Fact]
    public void ReturnCorrectValue()
    {
        IString stringPrimitive = new NewLineString();
        Assert.Equal(Environment.NewLine, stringPrimitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new NewLineString().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new NewLineString().ToString());
    }
}