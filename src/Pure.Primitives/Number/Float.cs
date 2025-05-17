using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record Float : IFloat
{
    private readonly float _value;

    public Float(float value)
    {
        _value = value;
    }

    float INumber<float>.Value => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}