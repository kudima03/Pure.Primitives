using Pure.Primitives.Bool;
using Pure.Primitives.Number;
using Pure.Primitives.Number.Base;

namespace Pure.Primitives.Tests.Number;

public sealed record LongChoiceTests
{
    [Fact]
    public void CorrectChooseOnTrueCondition()
    {
        INumber<long> valueOnTrue = new Long(1);
        INumber<long> valueOnFalse = new Long(0);
        INumber<long> choice = new LongChoice(new True(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnTrue.Value, choice.Value);
    }

    [Fact]
    public void CorrectChooseOnFalseCondition()
    {
        INumber<long> valueOnTrue = new Long(1);
        INumber<long> valueOnFalse = new Long(0);
        INumber<long> choice = new LongChoice(new False(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnFalse.Value, choice.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new LongChoice(new True(), new Long(1), new Long(0)).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new LongChoice(new False(), new Long(1), new Long(0)).ToString());
    }
}