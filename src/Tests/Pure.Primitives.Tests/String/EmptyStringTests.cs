using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.String;
using System.Collections;

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
    public void EnumeratesAsTyped()
    {
        IEnumerable<IChar> stringPrimitive = new EmptyString();
        Assert.True(string.Empty.SequenceEqual(stringPrimitive.Select(x => x.Value)));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable stringPrimitive = new EmptyString();

        ICollection<IChar> symbols = new List<IChar>();

        foreach (object symbol in stringPrimitive)
        {
            symbols.Add((symbol as IChar)!);
        }

        Assert.True(string.Empty.SequenceEqual(symbols.Select(x => x.Value)));
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