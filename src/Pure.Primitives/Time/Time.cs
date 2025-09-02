using System;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Number;

namespace Pure.Primitives.Time;

public sealed record Time : ITime
{
    private readonly TimeValidState _validState;

    private readonly INumber<ushort> _hour;

    private readonly INumber<ushort> _minute;

    private readonly INumber<ushort> _second;

    private readonly INumber<ushort> _millisecond;

    private readonly INumber<ushort> _microsecond;

    private readonly INumber<ushort> _nanosecond;

    public Time(TimeOnly timeOnly)
        : this(
            new UShort((ushort)timeOnly.Hour),
            new UShort((ushort)timeOnly.Minute),
            new UShort((ushort)timeOnly.Second),
            new UShort((ushort)timeOnly.Millisecond),
            new UShort((ushort)timeOnly.Microsecond),
            new UShort((ushort)timeOnly.Nanosecond)
        )
    { }

    public Time(INumber<ushort> hour, INumber<ushort> minute)
        : this(hour, minute, new Zero<ushort>()) { }

    public Time(INumber<ushort> hour, INumber<ushort> minute, INumber<ushort> second)
        : this(hour, minute, second, new Zero<ushort>()) { }

    public Time(
        INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second,
        INumber<ushort> millisecond
    )
        : this(hour, minute, second, millisecond, new Zero<ushort>()) { }

    public Time(
        INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second,
        INumber<ushort> millisecond,
        INumber<ushort> microsecond
    )
        : this(hour, minute, second, millisecond, microsecond, new Zero<ushort>()) { }

    public Time(
        INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second,
        INumber<ushort> millisecond,
        INumber<ushort> microsecond,
        INumber<ushort> nanosecond
    )
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
        _microsecond = microsecond;
        _nanosecond = nanosecond;
        _validState = new TimeValidState(
            hour,
            minute,
            second,
            millisecond,
            microsecond,
            nanosecond
        );
    }

    // Stryker disable once String
    public INumber<ushort> Hour =>
        _validState.BoolValue
            ? _hour
            : throw new ArgumentException($"{nameof(Hour)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Minute =>
        _validState.BoolValue
            ? _minute
            : throw new ArgumentException($"{nameof(Minute)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Second =>
        _validState.BoolValue
            ? _second
            : throw new ArgumentException($"{nameof(Second)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Millisecond =>
        _validState.BoolValue
            ? _millisecond
            : throw new ArgumentException($"{nameof(Millisecond)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Microsecond =>
        _validState.BoolValue
            ? _microsecond
            : throw new ArgumentException($"{nameof(Microsecond)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Nanosecond =>
        _validState.BoolValue
            ? _nanosecond
            : throw new ArgumentException($"{nameof(Nanosecond)} field is not valid.");

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
