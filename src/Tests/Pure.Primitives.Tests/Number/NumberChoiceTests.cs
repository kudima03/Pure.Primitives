using Pure.Primitives.Bool;
using Pure.Primitives.Number;
using Pure.Primitives.Number.Base;

namespace Pure.Primitives.Tests.Number;

public sealed record NumberChoiceTests
{
    [Fact]
    public void CorrectChooseOnTrueCondition()
    {
        INumber<int> valueOnTrue = new Int(1);
        INumber<int> valueOnFalse = new Int(0);
        INumber<int> choice = new NumberChoice<int>(new True(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnTrue.Value, choice.Value);
    }

    [Fact]
    public void CorrectChooseOnFalseCondition()
    {
        INumber<long> valueOnTrue = new Long(1);
        INumber<long> valueOnFalse = new Long(0);
        INumber<long> choice = new NumberChoice<long>(new False(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnFalse.Value, choice.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new NumberChoice<uint>(new True(), new UInt(1), new UInt(0)).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new NumberChoice<ushort>(new False(), new UShort(1), new UShort(0)).ToString());
    }
}