using System;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record Long : INumber<long>
{
    private readonly Lazy<long> _lazyValue;

    public Long(long value)
        : this(new Lazy<long>(() => value)) { }

    public Long(INumber<uint> value)
        : this(new Lazy<long>(() => value.NumberValue)) { }

    public Long(INumber<int> value)
        : this(new Lazy<long>(() => value.NumberValue)) { }

    public Long(INumber<ushort> value)
        : this(new Lazy<long>(() => value.NumberValue)) { }

    public Long(INumber<short> value)
        : this(new Lazy<long>(() => value.NumberValue)) { }

    private Long(Lazy<long> lazyValue)
    {
        _lazyValue = lazyValue;
    }

    long INumber<long>.NumberValue => _lazyValue.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
