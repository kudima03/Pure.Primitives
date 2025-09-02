using System;
using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.DayOfWeek;

public sealed record Friday : IDayOfWeek
{
    INumber<ushort> IDayOfWeek.DayNumberValue => new UShort(5);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
