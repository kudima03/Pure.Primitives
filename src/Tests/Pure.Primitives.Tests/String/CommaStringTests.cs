using System.Collections;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.String;

namespace Pure.Primitives.Tests.String;

public sealed record CommaStringTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        IString stringPrimitive = new CommaString();
        Assert.Equal(",", stringPrimitive.TextValue);
    }

    [Fact]
    public void EnumeratesAsTyped()
    {
        IEnumerable<IChar> stringPrimitive = new CommaString();
        Assert.True(",".SequenceEqual(stringPrimitive.Select(x => x.CharValue)));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable stringPrimitive = new CommaString();

        ICollection<IChar> symbols = [];

        foreach (object symbol in stringPrimitive)
        {
            symbols.Add((symbol as IChar)!);
        }

        Assert.True(",".SequenceEqual(symbols.Select(x => x.CharValue)));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new CommaString().GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new CommaString().ToString());
    }
}
