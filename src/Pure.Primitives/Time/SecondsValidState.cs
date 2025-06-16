using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Time;

internal sealed record SecondsValidState : IBool
{
    private readonly INumber<ushort> _seconds;

    public SecondsValidState(INumber<ushort> seconds)
    {
        _seconds = seconds;
    }

    public bool BoolValue => _seconds.NumberValue < 60;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}