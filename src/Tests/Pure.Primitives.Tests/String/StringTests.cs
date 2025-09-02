using System.Collections;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;

namespace Pure.Primitives.Tests.String;

using String = Primitives.String.String;

public sealed record StringTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const string testValue = "Test Value";
        IString stringPrimitive = new String(testValue);
        Assert.Equal(testValue, stringPrimitive.TextValue);
    }

    [Fact]
    public void EnumeratesAsTyped()
    {
        const string testValue = "Test Value";
        IEnumerable<IChar> stringPrimitive = new String(testValue);
        Assert.True(testValue.SequenceEqual(stringPrimitive.Select(x => x.CharValue)));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        const string testValue = "Test Value";

        IEnumerable stringPrimitive = new String(testValue);

        ICollection<IChar> symbols = [];

        foreach (object symbol in stringPrimitive)
        {
            symbols.Add((symbol as IChar)!);
        }

        Assert.True(testValue.SequenceEqual(symbols.Select(x => x.CharValue)));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new String("Test Value").GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new String("Test Value").ToString()
        );
    }
}
