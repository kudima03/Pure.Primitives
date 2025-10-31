using System;
using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Date;

public sealed record Date : IDate
{
    private readonly INumber<ushort> _day;

    private readonly INumber<ushort> _month;

    private readonly INumber<ushort> _year;

    private readonly IBool _validState;

    public Date(DateOnly date)
        : this(
            new UShort((ushort)date.Day),
            new UShort((ushort)date.Month),
            new UShort((ushort)date.Year)
        )
    { }

    public Date(INumber<ushort> day, INumber<ushort> month, INumber<ushort> year)
    {
        _day = day;
        _month = month;
        _year = year;
        _validState = new DateValidState(day, month, year);
    }

    // Stryker disable once String
    public INumber<ushort> Day =>
        _validState.BoolValue
            ? _day
            : throw new ArgumentException($"{nameof(Day)} field is not valid");

    // Stryker disable once String
    public INumber<ushort> Month =>
        _validState.BoolValue
            ? _month
            : throw new ArgumentException($"{nameof(Month)} field is not valid");

    // Stryker disable once String
    public INumber<ushort> Year =>
        _validState.BoolValue
            ? _year
            : throw new ArgumentException($"{nameof(Year)} field is not valid");

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
