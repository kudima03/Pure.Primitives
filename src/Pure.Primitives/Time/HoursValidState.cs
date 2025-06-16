using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Time;

internal sealed record HoursValidState : IBool
{
    private readonly INumber<ushort> _hours;

    public HoursValidState(INumber<ushort> hours)
    {
        _hours = hours;
    }

    public bool BoolValue => _hours.NumberValue < 24;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}