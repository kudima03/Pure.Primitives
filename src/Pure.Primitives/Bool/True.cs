using System;
using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool;

public sealed record True : IBool
{
    public bool BoolValue => true;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
