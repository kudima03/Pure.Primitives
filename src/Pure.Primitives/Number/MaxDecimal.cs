using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record MaxDecimal : INumber<decimal>
{
    decimal INumber<decimal>.NumberValue => decimal.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}