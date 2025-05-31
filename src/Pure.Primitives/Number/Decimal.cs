using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record Decimal : INumber<decimal>
{
    private readonly decimal _value;

    public Decimal(decimal value)
    {
        _value = value;
    }

    decimal INumber<decimal>.NumberValue => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}