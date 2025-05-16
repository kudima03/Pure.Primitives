using Pure.Primitives.Guid;

namespace Pure.Primitives.Tests.Guid;

using Guid = Primitives.Guid.Guid;

public sealed record GuidTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        System.Guid testValue = System.Guid.NewGuid();
        IGuid guidPrimitive = new Guid(testValue);
        Assert.Equal(testValue, guidPrimitive.Value);
    }

    [Fact]
    public void InitializeFromEmptyConstructor()
    {
        IGuid guidPrimitive = new Guid();
        Assert.True(System.Guid.TryParse(guidPrimitive.Value.ToString(), out System.Guid _));
    }

    [Fact]
    public void InitializeFromEmptyConstructorWithNotEmptyGuid()
    {
        IGuid guidPrimitive = new Guid();
        Assert.NotEqual(System.Guid.Empty, guidPrimitive.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Guid().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Guid().ToString());
    }
}