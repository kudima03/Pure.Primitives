using System;

namespace Pure.Primitives.Number;

public sealed record Long : ILong
{
    private readonly long _value;

    public Long(long value)
    {
        _value = value;
    }

    long ILong.Value => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}