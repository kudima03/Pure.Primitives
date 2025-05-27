using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record Long : INumber<long>
{
    private readonly long _value;

    public Long(long value)
    {
        _value = value;
    }

    long INumber<long>.NumberValue => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}