using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.DayOfWeek;

public sealed record Saturday : IDayOfWeek
{
    INumber<int> IDayOfWeek.DayNumberValue => new Int(6);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}