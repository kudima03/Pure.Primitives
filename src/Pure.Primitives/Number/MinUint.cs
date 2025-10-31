using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MinUint : INumber<uint>
{
    public uint NumberValue => uint.MinValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
