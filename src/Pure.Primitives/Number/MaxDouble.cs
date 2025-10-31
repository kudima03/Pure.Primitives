using System;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MaxDouble : INumber<double>
{
    public double NumberValue => double.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
