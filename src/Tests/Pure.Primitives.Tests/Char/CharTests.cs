using Pure.Primitives.Abstractions.Char;

namespace Pure.Primitives.Tests.Char;

using Char = Primitives.Char.Char;

public sealed record CharTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const char testValue = 'X';
        IChar charPrimitive = new Char(testValue);
        Assert.Equal(testValue, charPrimitive.CharValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new Char('X').GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new Char('X').ToString());
    }
}
