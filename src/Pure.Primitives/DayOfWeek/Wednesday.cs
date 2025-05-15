using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.DayOfWeek;

public sealed record Wednesday : IDayOfWeek
{
    IInt IDayOfWeek.DayNumber => new Int(3);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}