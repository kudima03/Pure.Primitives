using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MinLong : INumber<long>
{
    public long NumberValue => long.MinValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
