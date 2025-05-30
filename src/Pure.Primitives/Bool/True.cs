﻿using Pure.Primitives.Abstractions.Bool;
using System;

namespace Pure.Primitives.Bool;

public sealed record True : IBool
{
    bool IBool.BoolValue => true;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}