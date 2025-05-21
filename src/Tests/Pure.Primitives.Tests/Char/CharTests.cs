using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Char;

namespace Pure.Primitives.Tests.Char;

using Char = Primitives.Char.Char;

public sealed record CharTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const char testValue = 'X';
        IChar charPrimitive = new Char(testValue);
        Assert.Equal(testValue, charPrimitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Char('X').GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Char('X').ToString());
    }
}