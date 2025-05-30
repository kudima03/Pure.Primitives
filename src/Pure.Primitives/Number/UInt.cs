﻿using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Number;

public sealed record UInt : INumber<uint>
{
    private readonly uint _value;

    public UInt(uint value)
    {
        _value = value;
    }

    uint INumber<uint>.NumberValue => _value;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}