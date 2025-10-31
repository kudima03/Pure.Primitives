using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.Number;

public sealed record ULong : INumber<ulong>
{
    private readonly Lazy<ulong> _lazyValue;

    public ULong(ulong value)
        : this(new Lazy<ulong>(() => value)) { }

    public ULong(INumber<uint> value)
        : this(new Lazy<ulong>(() => value.NumberValue)) { }

    public ULong(INumber<ushort> value)
        : this(new Lazy<ulong>(() => value.NumberValue)) { }

    private ULong(Lazy<ulong> lazyValue)
    {
        _lazyValue = lazyValue;
    }

    public ulong NumberValue => _lazyValue.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
