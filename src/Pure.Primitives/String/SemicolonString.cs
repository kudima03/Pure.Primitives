using System.Collections;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.String;

namespace Pure.Primitives.String;

public sealed record SemicolonString : IString
{
    public string TextValue => ";";

    public IEnumerator<IChar> GetEnumerator()
    {
        return TextValue.Select(symbol => new Char.Char(symbol)).GetEnumerator();
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
