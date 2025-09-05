using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;

namespace Pure.Primitives.String;

using Char = Char.Char;

public sealed record DotString : IString
{
    private const string Value = ".";

    string IString.TextValue => Value;

    public IEnumerator<IChar> GetEnumerator()
    {
        return Value.Select(symbol => new Char(symbol)).GetEnumerator();
    }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
