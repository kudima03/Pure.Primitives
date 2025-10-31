using System;
using Pure.Primitives.Abstractions.Char;

namespace Pure.Primitives.Char;

public sealed record Char : IChar
{
    public Char(char value)
    {
        CharValue = value;
    }

    public char CharValue { get; }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
