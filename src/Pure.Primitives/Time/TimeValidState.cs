using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Time;

internal sealed record TimeValidState : IBool
{
    private readonly Lazy<bool> _lazyBool;

    public TimeValidState(
        INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second,
        INumber<ushort> millisecond,
        INumber<ushort> microsecond,
        INumber<ushort> nanosecond
    )
        : this(
            new Lazy<bool>(() =>
                new IBool[]
                {
                    new HoursValidState(hour),
                    new MinutesValidState(minute),
                    new SecondsValidState(second),
                    new MillisecondsValidState(millisecond),
                    new MicrosecondsValidState(microsecond),
                    new NanosecondsValidState(nanosecond),
                }.All(x => x.BoolValue)
            )
        )
    { }

    private TimeValidState(Lazy<bool> value)
    {
        _lazyBool = value;
    }

    public bool BoolValue => _lazyBool.Value;
}
