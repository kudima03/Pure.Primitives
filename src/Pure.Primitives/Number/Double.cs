using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record Double : IDouble
{
    private readonly double _value;

    public Double(double value)
    {
        _value = value;
    }

    double INumber<double>.Value => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}