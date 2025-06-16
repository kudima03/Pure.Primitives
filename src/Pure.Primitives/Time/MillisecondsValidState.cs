using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Time;

internal sealed record MillisecondsValidState : IBool
{
    private readonly INumber<ushort> _milliseconds;

    public MillisecondsValidState(INumber<ushort> milliseconds)
    {
        _milliseconds = milliseconds;
    }

    public bool BoolValue => _milliseconds.NumberValue < 1000;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}