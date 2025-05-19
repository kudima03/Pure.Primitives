using Pure.Primitives.Bool;
using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record UIntChoice : INumber<uint>
{
    private readonly IBool _condition;

    private readonly INumber<uint> _valueOnTrue;

    private readonly INumber<uint> _valueOnFalse;

    public UIntChoice(IBool condition, INumber<uint> valueOnTrue, INumber<uint> valueOnFalse)
    {
        _condition = condition;
        _valueOnTrue = valueOnTrue;
        _valueOnFalse = valueOnFalse;
    }

    uint INumber<uint>.Value => _condition.Value ? _valueOnTrue.Value : _valueOnFalse.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}