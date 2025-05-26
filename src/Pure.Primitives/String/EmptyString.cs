using Pure.Primitives.Abstractions.String;
using System;

namespace Pure.Primitives.String;

public sealed record EmptyString : IString
{
    string IString.Value => string.Empty;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}