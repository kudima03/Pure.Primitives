using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record Decimal : INumber<decimal>
{
    private readonly Lazy<decimal> _lazyValue;

    public Decimal(decimal value)
        : this(new Lazy<decimal>(() => value)) { }

    public Decimal(INumber<double> value)
        : this(new Lazy<decimal>(() => Convert.ToDecimal(value.NumberValue))) { }

    public Decimal(INumber<float> value)
        : this(new Lazy<decimal>(() => Convert.ToDecimal(value.NumberValue))) { }

    public Decimal(INumber<long> value)
        : this(new Lazy<decimal>(() => Convert.ToDecimal(value.NumberValue))) { }

    public Decimal(INumber<ulong> value)
        : this(new Lazy<decimal>(() => Convert.ToDecimal(value.NumberValue))) { }

    public Decimal(INumber<uint> value)
        : this(new Lazy<decimal>(() => Convert.ToDecimal(value.NumberValue))) { }

    public Decimal(INumber<int> value)
        : this(new Lazy<decimal>(() => Convert.ToDecimal(value.NumberValue))) { }

    public Decimal(INumber<short> value)
        : this(new Lazy<decimal>(() => Convert.ToDecimal(value.NumberValue))) { }

    public Decimal(INumber<ushort> value)
        : this(new Lazy<decimal>(() => Convert.ToDecimal(value.NumberValue))) { }

    private Decimal(Lazy<decimal> lazyValue)
    {
        _lazyValue = lazyValue;
    }

    decimal INumber<decimal>.NumberValue => _lazyValue.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}