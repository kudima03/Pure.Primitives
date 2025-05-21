using Pure.Primitives.Abstractions.Bool;
using System;

namespace Pure.Primitives.Bool;

public sealed record False : IBool
{
    bool IBool.Value => false;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}