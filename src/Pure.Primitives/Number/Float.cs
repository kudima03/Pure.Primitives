using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record Float : INumber<float>
{
    private readonly Lazy<float> _lazyValue;

    public Float(float value)
        : this(new Lazy<float>(() => value)) { }

    public Float(INumber<ulong> value)
        : this(new Lazy<float>(() => value.NumberValue)) { }

    public Float(INumber<long> value)
        : this(new Lazy<float>(() => value.NumberValue)) { }

    public Float(INumber<uint> value)
        : this(new Lazy<float>(() => value.NumberValue)) { }

    public Float(INumber<int> value)
        : this(new Lazy<float>(() => value.NumberValue)) { }

    public Float(INumber<ushort> value)
        : this(new Lazy<float>(() => value.NumberValue)) { }

    public Float(INumber<short> value)
        : this(new Lazy<float>(() => value.NumberValue)) { }

    private Float(Lazy<float> lazyValue)
    {
        _lazyValue = lazyValue;
    }

    public float NumberValue => _lazyValue.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
