using System;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record Short : INumber<short>
{
    public Short(short value)
    {
        NumberValue = value;
    }

    public short NumberValue { get; }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
