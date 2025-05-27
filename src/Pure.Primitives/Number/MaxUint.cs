using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record MaxUint : INumber<uint>
{
    uint INumber<uint>.Value => uint.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}