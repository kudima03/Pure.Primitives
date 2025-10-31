using System;
using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record Int : INumber<int>
{
    private readonly Lazy<int> _lazyValue;

    public Int(int value)
        : this(new Lazy<int>(() => value)) { }

    public Int(INumber<ushort> value)
        : this(new Lazy<int>(() => value.NumberValue)) { }

    public Int(INumber<short> value)
        : this(new Lazy<int>(() => value.NumberValue)) { }

    private Int(Lazy<int> lazyValue)
    {
        _lazyValue = lazyValue;
    }

    public int NumberValue => _lazyValue.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
