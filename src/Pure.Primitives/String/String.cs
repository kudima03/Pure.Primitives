using Pure.Primitives.Abstractions.String;
using System;

namespace Pure.Primitives.String;

public sealed record String : IString
{
    private readonly string _value;

    public String(string value)
    {
        _value = value;
    }

    string IString.Value => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}