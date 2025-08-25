using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record Short : INumber<short>
{
    private readonly short _value;

    public Short(short value)
    {
        _value = value;
    }

    short INumber<short>.NumberValue => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}