using Pure.Primitives.Number;
using Pure.Primitives.Number.Base;
using System;

namespace Pure.Primitives.DayOfWeek;

public sealed record Thursday : IDayOfWeek
{
    INumber<int> IDayOfWeek.DayNumber => new Int(4);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}