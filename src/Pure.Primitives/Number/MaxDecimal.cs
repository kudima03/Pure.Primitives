using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MaxDecimal : INumber<decimal>
{
    public decimal NumberValue => decimal.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
