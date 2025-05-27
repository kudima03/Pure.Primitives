using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record MaxUshort : INumber<ushort>
{
    ushort INumber<ushort>.Value => ushort.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}