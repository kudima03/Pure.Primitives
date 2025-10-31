using System;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MaxUlong : INumber<ulong>
{
    public ulong NumberValue => ulong.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
