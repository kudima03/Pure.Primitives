using Pure.Primitives.Abstractions.Bool;
using System;

namespace Pure.Primitives.Bool;

public sealed record CachedBool : IBool
{
    private readonly Lazy<bool> _lazyValue;

    public CachedBool(IBool value) : this(new Lazy<bool>(() => value.BoolValue)) { }

    private CachedBool(Lazy<bool> lazyValue)
    {
        _lazyValue = lazyValue;
    }

    bool IBool.BoolValue => _lazyValue.Value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}