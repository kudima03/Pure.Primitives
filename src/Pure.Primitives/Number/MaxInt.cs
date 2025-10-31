using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MaxInt : INumber<int>
{
    public int NumberValue => int.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
