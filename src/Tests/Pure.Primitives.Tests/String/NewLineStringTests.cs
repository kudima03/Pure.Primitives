using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.String;
using System.Collections;

namespace Pure.Primitives.Tests.String;

public sealed record NewLineStringTests
{
    [Fact]
    public void ReturnCorrectValue()
    {
        IString stringPrimitive = new NewLineString();
        Assert.Equal(Environment.NewLine, stringPrimitive.TextValue);
    }

    [Fact]
    public void EnumeratesAsTyped()
    {
        IEnumerable<IChar> stringPrimitive = new NewLineString();
        Assert.True(Environment.NewLine.SequenceEqual(stringPrimitive.Select(x => x.CharValue)));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable stringPrimitive = new NewLineString();

        ICollection<IChar> symbols = new List<IChar>();

        foreach (object symbol in stringPrimitive)
        {
            symbols.Add((symbol as IChar)!);
        }

        Assert.True(Environment.NewLine.SequenceEqual(symbols.Select(x => x.CharValue)));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new NewLineString().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new NewLineString().ToString());
    }
}