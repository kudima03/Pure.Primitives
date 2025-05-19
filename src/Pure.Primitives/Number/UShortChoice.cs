using Pure.Primitives.Bool;
using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.Number;

public sealed record UShortChoice : INumber<ushort>
{
    private readonly IBool _condition;

    private readonly INumber<ushort> _valueOnTrue;

    private readonly INumber<ushort> _valueOnFalse;

    public UShortChoice(IBool condition, INumber<ushort> valueOnTrue, INumber<ushort> valueOnFalse)
    {
        _condition = condition;
        _valueOnTrue = valueOnTrue;
        _valueOnFalse = valueOnFalse;
    }

    ushort INumber<ushort>.Value => _condition.Value ? _valueOnTrue.Value : _valueOnFalse.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}