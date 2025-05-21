using Pure.Primitives.Abstractions.String;
using Pure.Primitives.String;

namespace Pure.Primitives.Tests.String;

using String = Primitives.String.String;

public sealed record StringTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const string testValue = "Test Value";
        IString stringPrimitive = new String(testValue);
        Assert.Equal(testValue, stringPrimitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new String("Test Value").GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new String("Test Value").ToString());
    }
}