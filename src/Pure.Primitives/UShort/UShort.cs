using System;

namespace Pure.Primitives.UShort;

public sealed record UShort : IUShort
{
    private readonly ushort _value;

    public UShort(ushort value)
    {
        _value = value;
    }

    ushort IUShort.Value => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}