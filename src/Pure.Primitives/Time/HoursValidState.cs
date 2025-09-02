using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Time;

internal sealed record HoursValidState : IBool
{
    private readonly INumber<ushort> _hours;

    public HoursValidState(INumber<ushort> hours)
    {
        _hours = hours;
    }

    public bool BoolValue => _hours.NumberValue < 24;
}
