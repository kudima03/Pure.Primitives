using Pure.Primitives.Abstractions.String;
using System;

namespace Pure.Primitives.String;

public sealed record NewLineString : IString
{
    string IString.Value => Environment.NewLine;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}