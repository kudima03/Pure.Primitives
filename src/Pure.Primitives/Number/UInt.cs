using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record UInt : IUInt
{
    private readonly uint _value;

    public UInt(uint value)
    {
        _value = value;
    }

    uint INumber<uint>.Value => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}