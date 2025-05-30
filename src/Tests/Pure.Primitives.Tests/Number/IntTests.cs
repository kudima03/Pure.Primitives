﻿using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Number;

namespace Pure.Primitives.Tests.Number;

public sealed record IntTests
{
    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const int testValue = 1910283761;
        INumber<int> doublePrimitive = new Int(testValue);
        Assert.Equal(testValue, doublePrimitive.NumberValue);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Int(1845986329).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Int(365971267).ToString());
    }
}