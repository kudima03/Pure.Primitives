using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Pure.Primitives.String;

public sealed record EmptyString : IString
{
    private readonly string _value = string.Empty;

    string IString.TextValue => _value;

    public IEnumerator<IChar> GetEnumerator()
    {
        return _value.Select(symbol => new Char.Char(symbol)).GetEnumerator();
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