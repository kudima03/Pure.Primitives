using Pure.Primitives.Bool;
using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record LongChoice : INumber<long>
{
    private readonly IBool _condition;

    private readonly INumber<long> _valueOnTrue;

    private readonly INumber<long> _valueOnFalse;

    public LongChoice(IBool condition, INumber<long> valueOnTrue, INumber<long> valueOnFalse)
    {
        _condition = condition;
        _valueOnTrue = valueOnTrue;
        _valueOnFalse = valueOnFalse;
    }

    long INumber<long>.Value => _condition.Value ? _valueOnTrue.Value : _valueOnFalse.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}