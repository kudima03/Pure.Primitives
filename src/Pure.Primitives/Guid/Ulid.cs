using Pure.Primitives.Abstractions.Guid;

namespace Pure.Primitives.Guid;

public sealed record Ulid : IGuid
{
    public Ulid()
        : this(ByteAether.Ulid.Ulid.New()) { }

    public Ulid(System.Guid value)
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
