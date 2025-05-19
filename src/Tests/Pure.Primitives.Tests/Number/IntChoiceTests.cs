using Pure.Primitives.Bool;
using Pure.Primitives.Number;
using Pure.Primitives.Number.Base;

namespace Pure.Primitives.Tests.Number;

public sealed record IntChoiceTests
{
    [Fact]
    public void CorrectChooseOnTrueCondition()
    {
        INumber<int> valueOnTrue = new Int(1);
        INumber<int> valueOnFalse = new Int(0);
        INumber<int> choice = new IntChoice(new True(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnTrue.Value, choice.Value);
    }

    [Fact]
    public void CorrectChooseOnFalseCondition()
    {
        INumber<int> valueOnTrue = new Int(1);
        INumber<int> valueOnFalse = new Int(0);
        INumber<int> choice = new IntChoice(new False(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnFalse.Value, choice.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new IntChoice(new True(), new Int(1), new Int(0)).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new IntChoice(new False(), new Int(1), new Int(0)).ToString());
    }
}