using Pure.Primitives.Bool;
using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record DoubleChoice : INumber<double>
{
    private readonly IBool _condition;

    private readonly INumber<double> _valueOnTrue;

    private readonly INumber<double> _valueOnFalse;

    public DoubleChoice(IBool condition, INumber<double> valueOnTrue, INumber<double> valueOnFalse)
    {
        _condition = condition;
        _valueOnTrue = valueOnTrue;
        _valueOnFalse = valueOnFalse;
    }

    double INumber<double>.Value => _condition.Value ? _valueOnTrue.Value : _valueOnFalse.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}