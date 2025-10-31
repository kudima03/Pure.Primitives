using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record MaxFloat : INumber<float>
{
    public float NumberValue => float.MaxValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
