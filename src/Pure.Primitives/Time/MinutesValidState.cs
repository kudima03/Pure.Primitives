using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Time;

internal sealed record MinutesValidState : IBool
{
    private readonly INumber<ushort> _minutes;

    public MinutesValidState(INumber<ushort> minutes)
    {
        _minutes = minutes;
    }


    public bool BoolValue => _minutes.NumberValue < 60;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}