using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Time;

internal sealed record NanosecondsValidState : IBool
{
    private readonly INumber<ushort> _nanoseconds;

    public NanosecondsValidState(INumber<ushort> nanoseconds)
    {
        _nanoseconds = nanoseconds;
    }

    public bool BoolValue => _nanoseconds.NumberValue < 1000;
}