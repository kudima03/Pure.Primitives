using System;
using Pure.Primitives.Abstractions.Guid;

namespace Pure.Primitives.Guid;

public sealed record Guid : IGuid
{
    public Guid()
        : this(System.Guid.NewGuid()) { }

    public Guid(System.Guid value)
    {
        GuidValue = value;
    }

    public System.Guid GuidValue { get; }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
