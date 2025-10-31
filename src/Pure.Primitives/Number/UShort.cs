using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record UShort : INumber<ushort>
{
    public UShort(ushort value)
    {
        NumberValue = value;
    }

    public ushort NumberValue { get; }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
