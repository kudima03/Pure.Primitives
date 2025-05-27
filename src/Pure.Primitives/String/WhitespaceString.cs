using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Pure.Primitives.String;

public sealed record WhitespaceString : IString
{
    private const string value = " ";

    string IString.TextValue => value;

    public IEnumerator<IChar> GetEnumerator()
    {
        return value.Select(symbol => new Char.Char(symbol)).GetEnumerator();
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