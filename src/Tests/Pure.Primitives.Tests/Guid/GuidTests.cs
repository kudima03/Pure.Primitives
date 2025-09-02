using Pure.Primitives.Abstractions.Guid;

namespace Pure.Primitives.Tests.Guid;

using Guid = Primitives.Guid.Guid;

public sealed record GuidTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        System.Guid testValue = System.Guid.NewGuid();
        IGuid guidPrimitive = new Guid(testValue);
        Assert.Equal(testValue, guidPrimitive.GuidValue);
    }

    [Fact]
    public void InitializeFromEmptyConstructor()
    {
        IGuid guidPrimitive = new Guid();
        Assert.True(
            System.Guid.TryParse(guidPrimitive.GuidValue.ToString(), out System.Guid _)
        );
    }

    [Fact]
    public void InitializeFromEmptyConstructorWithNotEmptyGuid()
    {
        IGuid guidPrimitive = new Guid();
        Assert.NotEqual(System.Guid.Empty, guidPrimitive.GuidValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new Guid().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new Guid().ToString());
    }
}
