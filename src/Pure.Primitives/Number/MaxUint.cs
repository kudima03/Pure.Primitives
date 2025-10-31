using System;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MaxUint : INumber<uint>
{
    public uint NumberValue => uint.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
