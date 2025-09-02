using System;
using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.DayOfWeek;

public sealed record Wednesday : IDayOfWeek
{
    INumber<ushort> IDayOfWeek.DayNumberValue => new UShort(3);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
