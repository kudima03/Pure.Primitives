using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MaxShort : INumber<short>
{
    public short NumberValue => short.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
