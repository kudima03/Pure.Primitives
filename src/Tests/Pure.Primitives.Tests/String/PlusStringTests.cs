using System.Collections;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.String;

namespace Pure.Primitives.Tests.String;

public sealed record PlusStringTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        IString stringPrimitive = new PlusString();
        Assert.Equal("+", stringPrimitive.TextValue);
    }

    [Fact]
    public void EnumeratesAsTyped()
    {
        IEnumerable<IChar> stringPrimitive = new PlusString();
        Assert.True("+".SequenceEqual(stringPrimitive.Select(x => x.CharValue)));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable stringPrimitive = new PlusString();

        ICollection<IChar> symbols = [];

        foreach (object symbol in stringPrimitive)
        {
            symbols.Add((symbol as IChar)!);
        }

        Assert.True("+".SequenceEqual(symbols.Select(x => x.CharValue)));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new PlusString().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new PlusString().ToString());
    }
}
