using Pure.Primitives.Abstractions.Guid;
using System;

namespace Pure.Primitives.Guid;

public sealed record EmptyGuid : IGuid
{
    public System.Guid GuidValue => System.Guid.Empty;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}