using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Time;

internal sealed record MicrosecondsValidState : IBool
{
    private readonly INumber<ushort> _microseconds;

    public MicrosecondsValidState(INumber<ushort> microseconds)
    {
        _microseconds = microseconds;
    }

    public bool BoolValue => _microseconds.NumberValue < 1000;
}