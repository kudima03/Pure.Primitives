using Pure.Primitives.Bool;
using Pure.Primitives.Number;
using Pure.Primitives.Number.Base;

namespace Pure.Primitives.Tests.Number;

public sealed record UIntChoiceTests
{
    [Fact]
    public void CorrectChooseOnTrueCondition()
    {
        INumber<uint> valueOnTrue = new UInt(1);
        INumber<uint> valueOnFalse = new UInt(0);
        INumber<uint> choice = new UIntChoice(new True(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnTrue.Value, choice.Value);
    }

    [Fact]
    public void CorrectChooseOnFalseCondition()
    {
        INumber<uint> valueOnTrue = new UInt(1);
        INumber<uint> valueOnFalse = new UInt(0);
        INumber<uint> choice = new UIntChoice(new False(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnFalse.Value, choice.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new UIntChoice(new True(), new UInt(1), new UInt(0)).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new UIntChoice(new False(), new UInt(1), new UInt(0)).ToString());
    }
}