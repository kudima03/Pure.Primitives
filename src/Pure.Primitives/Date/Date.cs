using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.Date;

public sealed record Date : IDate
{
    private readonly INumber<ushort> _day;

    private readonly INumber<ushort> _month;

    private readonly INumber<ushort> _year;

    public Date(DateOnly date) : 
        this(new UShort((ushort)date.Day), 
            new UShort((ushort)date.Month), 
            new UShort((ushort)date.Year)) { }

    public Date(INumber<ushort> day, INumber<ushort> month, INumber<ushort> year)
    {
        _day = day;
        _month = month;
        _year = year;
    }

    DateOnly IDate.DateValue => new DateOnly(_year.NumberValue, _month.NumberValue, _day.NumberValue);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}