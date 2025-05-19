using Pure.Primitives.Bool;
using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record IntChoice : INumber<int>
{
    private readonly IBool _condition;

    private readonly INumber<int> _valueOnTrue;

    private readonly INumber<int> _valueOnFalse;

    public IntChoice(IBool condition, INumber<int> valueOnTrue, INumber<int> valueOnFalse)
    {
        _condition = condition;
        _valueOnTrue = valueOnTrue;
        _valueOnFalse = valueOnFalse;
    }

    int INumber<int>.Value => _condition.Value ? _valueOnTrue.Value : _valueOnFalse.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}