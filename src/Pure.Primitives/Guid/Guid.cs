using Pure.Primitives.Abstractions.Guid;
using System;

namespace Pure.Primitives.Guid;

public sealed record Guid : IGuid
{
    private readonly System.Guid _value;

    public Guid() : this(System.Guid.NewGuid()) { }

    public Guid(System.Guid value)
    {
        _value = value;
    }

    System.Guid IGuid.GuidValue => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}