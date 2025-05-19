using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record UShort : INumber<ushort>
{
    private readonly ushort _value;

    public UShort(ushort value)
    {
        _value = value;
    }

    ushort INumber<ushort>.Value => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}