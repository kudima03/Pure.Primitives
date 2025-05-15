using System;

namespace Pure.Primitives.Char;

public sealed record Char : IChar
{
    private readonly char _value;

    public Char(char value)
    {
        _value = value;
    }

    char IChar.Value => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}