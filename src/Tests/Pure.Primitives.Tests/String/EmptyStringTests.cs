using Pure.Primitives.Abstractions.String;
using Pure.Primitives.String;

namespace Pure.Primitives.Tests.String;

public sealed record EmptyStringTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        IString stringPrimitive = new EmptyString();
        Assert.Equal(string.Empty, stringPrimitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new EmptyString().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new EmptyString().ToString());
    }
}