using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MinDouble : INumber<double>
{
    public double NumberValue => double.MinValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
