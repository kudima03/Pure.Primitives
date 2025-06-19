using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Guid;

namespace Pure.Primitives.Tests.Guid;

public sealed record EmptyGuidTests
{
    [Fact]
    public void InitializeFromEmptyConstructorWithEmptyGuid()
    {
        IGuid guidPrimitive = new EmptyGuid();
        Assert.Equal(System.Guid.Empty, guidPrimitive.GuidValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new EmptyGuid().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new EmptyGuid().ToString());
    }
}