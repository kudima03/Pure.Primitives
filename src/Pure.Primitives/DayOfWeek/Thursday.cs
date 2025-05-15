using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.DayOfWeek;

public sealed record Thursday : IDayOfWeek
{
    IInt IDayOfWeek.DayNumber => new Int(4);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}