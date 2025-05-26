using Pure.Primitives.Abstractions.String;
using System;

namespace Pure.Primitives.String;

public sealed record WhitespaceString : IString
{
    private const string value = " ";

    string IString.Value => value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}