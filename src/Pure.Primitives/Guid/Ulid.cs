using System;
using Pure.Primitives.Abstractions.Guid;

namespace Pure.Primitives.Guid;

public sealed record Ulid : IGuid
{
    private readonly System.Guid _value;

    public Ulid()
        : this(System.Guid.CreateVersion7()) { }

    public Ulid(System.Guid value)
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
