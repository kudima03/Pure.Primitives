using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.Date;

public sealed record CurrentDate : IDate
{
    public INumber<ushort> Day { get; } = new UShort((ushort)System.DateTime.Now.Day);

    public INumber<ushort> Month { get; } = new UShort((ushort)System.DateTime.Now.Month);

    public INumber<ushort> Year { get; } = new UShort((ushort)System.DateTime.Now.Year);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}