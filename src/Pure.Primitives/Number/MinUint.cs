﻿using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record MinUint : INumber<uint>
{
    uint INumber<uint>.NumberValue => uint.MinValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}