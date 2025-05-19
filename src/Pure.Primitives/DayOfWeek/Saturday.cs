using Pure.Primitives.Number;
using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.DayOfWeek;

public sealed record Saturday : IDayOfWeek
{
    INumber<int> IDayOfWeek.DayNumber => new Int(6);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}