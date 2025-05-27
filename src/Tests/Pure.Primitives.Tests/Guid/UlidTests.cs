using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Guid;

namespace Pure.Primitives.Tests.Guid;

public sealed record UlidTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        System.Guid testValue = System.Guid.CreateVersion7();
        IGuid guidPrimitive = new Ulid(testValue);
        Assert.Equal(testValue, guidPrimitive.GuidValue);
    }

    [Fact]
    public void InitializeFromEmptyConstructor()
    {
        IGuid guidPrimitive = new Ulid();
        Assert.True(System.Guid.TryParse(guidPrimitive.GuidValue.ToString(), out System.Guid _));
    }

    [Fact]
    public async Task ProduceSequentialValues()
    {
        ICollection<(int orderNumber, IGuid ulid)> values = new List<(int, IGuid)>();

        foreach (int i in Enumerable.Range(0, 5))
        {
            values.Add((i, new Ulid()));
            // Ulid has millisecond precision
            await Task.Delay(1);
        }

        Assert.True(values.Select(x => x.orderNumber)
            .SequenceEqual(values.OrderBy(x => x.ulid.GuidValue).Select(x => x.orderNumber)));
    }

    [Fact]
    public void InitializeFromEmptyConstructorWithNotEmptyGuid()
    {
        IGuid guidPrimitive = new Ulid();
        Assert.NotEqual(System.Guid.Empty, guidPrimitive.GuidValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Ulid().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Ulid().ToString());
    }
}