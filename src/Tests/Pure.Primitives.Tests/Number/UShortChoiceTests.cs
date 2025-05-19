using Pure.Primitives.Bool;
using Pure.Primitives.Number;
using Pure.Primitives.Number.Base;

namespace Pure.Primitives.Tests.Number;

public sealed record UShortChoiceTests
{
    [Fact]
    public void CorrectChooseOnTrueCondition()
    {
        INumber<ushort> valueOnTrue = new UShort(1);
        INumber<ushort> valueOnFalse = new UShort(0);
        INumber<ushort> choice = new UShortChoice(new True(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnTrue.Value, choice.Value);
    }

    [Fact]
    public void CorrectChooseOnFalseCondition()
    {
        INumber<ushort> valueOnTrue = new UShort(1);
        INumber<ushort> valueOnFalse = new UShort(0);
        INumber<ushort> choice = new UShortChoice(new False(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnFalse.Value, choice.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new UShortChoice(new True(), new UShort(1), new UShort(0)).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new UShortChoice(new False(), new UShort(1), new UShort(0)).ToString());
    }
}