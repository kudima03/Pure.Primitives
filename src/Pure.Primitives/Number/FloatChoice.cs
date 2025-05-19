using Pure.Primitives.Bool;
using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record FloatChoice : INumber<float>
{
    private readonly IBool _condition;

    private readonly INumber<float> _valueOnTrue;

    private readonly INumber<float> _valueOnFalse;

    public FloatChoice(IBool condition, INumber<float> valueOnTrue, INumber<float> valueOnFalse)
    {
        _condition = condition;
        _valueOnTrue = valueOnTrue;
        _valueOnFalse = valueOnFalse;
    }

    float INumber<float>.Value => _condition.Value ? _valueOnTrue.Value : _valueOnFalse.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}