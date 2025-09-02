using System;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record UShort : INumber<ushort>
{
    private readonly ushort _value;

    public UShort(ushort value)
    {
        _value = value;
    }

    ushort INumber<ushort>.NumberValue => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
