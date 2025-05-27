using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record Int : INumber<int>
{
    private readonly int _value;

    public Int(int value)
    {
        _value = value;
    }

    int INumber<int>.NumberValue => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}