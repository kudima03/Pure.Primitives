using System;
using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool;

public sealed record False : IBool
{
    bool IBool.BoolValue => false;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
