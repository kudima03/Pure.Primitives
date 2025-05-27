using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Abstractions.DateTime;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.DateTime;

public sealed record DateTime : IDateTime
{
    private readonly INumber<ushort> _day;
    private readonly INumber<ushort> _month;
    private readonly INumber<ushort> _year;
    private readonly INumber<ushort> _hour;
    private readonly INumber<ushort> _minute;
    private readonly INumber<ushort> _second;
    private readonly INumber<ushort> _millisecond;
    private readonly INumber<ushort> _microsecond;

    public DateTime(IDate date) : this(date.DateValue) { }

    public DateTime(IDate date, ITime time) : this(date.DateValue, time.TimeValue) { }

    public DateTime(DateOnly date) : this(date, new TimeOnly(0, 0)) { }

    public DateTime(DateOnly date, TimeOnly time) : this(
        new UShort((ushort)date.Day),
        new UShort((ushort)date.Month),
        new UShort((ushort)date.Year),
        new UShort((ushort)time.Hour),
        new UShort((ushort)time.Minute),
        new UShort((ushort)time.Second),
        new UShort((ushort)time.Millisecond),
        new UShort((ushort)time.Microsecond))
    { }

    public DateTime(INumber<ushort> day,
        INumber<ushort> month,
        INumber<ushort> year,
        INumber<ushort> hour,
        INumber<ushort> minute,
        INumber<ushort> second,
        INumber<ushort> millisecond,
        INumber<ushort> microsecond)
    {
        _day = day;
        _month = month;
        _year = year;
        _hour = hour;
        _minute = minute;
        _second = second;
        _millisecond = millisecond;
        _microsecond = microsecond;
    }

    DateOnly IDate.DateValue => new DateOnly(
        _year.NumberValue,
        _month.NumberValue,
        _day.NumberValue);

    TimeOnly ITime.TimeValue => new TimeOnly(
        _hour.NumberValue,
        _minute.NumberValue,
        _second.NumberValue,
        _millisecond.NumberValue,
        _microsecond.NumberValue);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}