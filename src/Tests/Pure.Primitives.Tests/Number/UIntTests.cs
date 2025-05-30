﻿using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record UIntTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const uint testValue = 3910283761;
        INumber<uint> uintPrimitive = new UInt(testValue);
        Assert.Equal(testValue, uintPrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new UInt(754514523).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new UInt(918023479).ToString());
    }
}