using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record Double : INumber<double>
{
    private readonly Lazy<double> _lazyValue;

    public Double(double value)
        : this(new Lazy<double>(() => value)) { }

    public Double(INumber<decimal> value)
        : this(new Lazy<double>(() => Convert.ToDouble(value.NumberValue))) { }

    public Double(INumber<float> value)
        : this(new Lazy<double>(() => value.NumberValue)) { }

    public Double(INumber<ulong> value)
        : this(new Lazy<double>(() => value.NumberValue)) { }

    public Double(INumber<long> value)
        : this(new Lazy<double>(() => value.NumberValue)) { }

    public Double(INumber<uint> value)
        : this(new Lazy<double>(() => value.NumberValue)) { }

    public Double(INumber<int> value)
        : this(new Lazy<double>(() => value.NumberValue)) { }

    public Double(INumber<ushort> value)
        : this(new Lazy<double>(() => value.NumberValue)) { }

    public Double(INumber<short> value)
        : this(new Lazy<double>(() => value.NumberValue)) { }

    private Double(Lazy<double> lazyValue)
    {
        _lazyValue = lazyValue;
    }

    double INumber<double>.NumberValue => _lazyValue.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}