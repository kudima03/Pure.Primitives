﻿using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.Date;

public sealed record Date : IDate
{
    public Date(DateOnly date) :
        this(new UShort((ushort)date.Day),
            new UShort((ushort)date.Month),
            new UShort((ushort)date.Year))
    { }

    public Date(INumber<ushort> day, INumber<ushort> month, INumber<ushort> year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public INumber<ushort> Day { get; }

    public INumber<ushort> Month { get; }

    public INumber<ushort> Year { get; }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}