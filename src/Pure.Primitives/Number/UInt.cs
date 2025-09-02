using System;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record UInt : INumber<uint>
{
    private readonly Lazy<uint> _lazyValue;

    public UInt(uint value)
        : this(new Lazy<uint>(() => value)) { }

    public UInt(INumber<ushort> value)
        : this(new Lazy<uint>(() => value.NumberValue)) { }

    private UInt(Lazy<uint> lazyValue)
    {
        _lazyValue = lazyValue;
    }

    uint INumber<uint>.NumberValue => _lazyValue.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
