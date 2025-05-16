using System;

namespace Pure.Primitives.Guid;

public sealed record Guid : IGuid
{
    private readonly System.Guid _value;

    public Guid() : this(new System.Guid()) { }

    public Guid(System.Guid value)
    {
        _value = value;
    }

    System.Guid IGuid.Value => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}