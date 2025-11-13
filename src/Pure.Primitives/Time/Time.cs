using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Number;

namespace Pure.Primitives.Time;

public sealed record Time : ITime
{
    private readonly TimeValidState _validState;

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
        Hour = hour;
        Minute = minute;
        Second = second;
        Millisecond = millisecond;
        Microsecond = microsecond;
        Nanosecond = nanosecond;
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
            ? field
            : throw new ArgumentException($"{nameof(Hour)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Minute =>
        _validState.BoolValue
            ? field
            : throw new ArgumentException($"{nameof(Minute)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Second =>
        _validState.BoolValue
            ? field
            : throw new ArgumentException($"{nameof(Second)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Millisecond =>
        _validState.BoolValue
            ? field
            : throw new ArgumentException($"{nameof(Millisecond)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Microsecond =>
        _validState.BoolValue
            ? field
            : throw new ArgumentException($"{nameof(Microsecond)} field is not valid.");

    // Stryker disable once String
    public INumber<ushort> Nanosecond =>
        _validState.BoolValue
            ? field
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
