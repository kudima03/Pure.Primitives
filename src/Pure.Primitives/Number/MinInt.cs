using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MinInt : INumber<int>
{
    public int NumberValue => int.MinValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
