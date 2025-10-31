using System;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MinShort : INumber<short>
{
    public short NumberValue => short.MinValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
