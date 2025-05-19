using Pure.Primitives.Bool;
using Pure.Primitives.Number;
using Pure.Primitives.Number.Base;

namespace Pure.Primitives.Tests.Number;

using Double = Primitives.Number.Double;

public sealed record DoubleChoiceTests
{
    [Fact]
    public void CorrectChooseOnTrueCondition()
    {
        INumber<double> valueOnTrue = new Double(1.01);
        INumber<double> valueOnFalse = new Double(0.01);
        INumber<double> choice = new DoubleChoice(new True(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnTrue.Value, choice.Value);
    }

    [Fact]
    public void CorrectChooseOnFalseCondition()
    {
        INumber<double> valueOnTrue = new Double(1.01);
        INumber<double> valueOnFalse = new Double(0.01);
        INumber<double> choice = new DoubleChoice(new False(), valueOnTrue, valueOnFalse);
        Assert.Equal(valueOnFalse.Value, choice.Value);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new DoubleChoice(new True(), new Double(1.01), new Double(0.01)).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new DoubleChoice(new False(), new Double(1.01), new Double(0.01)).ToString());
    }
}