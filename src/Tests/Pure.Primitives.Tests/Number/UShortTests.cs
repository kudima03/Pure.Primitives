﻿using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record UShortTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const ushort testValue = 11324;
        INumber<ushort> ushortPrimitive = new UShort(testValue);
        Assert.Equal(testValue, ushortPrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new UShort(8789).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new UShort(56478).ToString());
    }
}