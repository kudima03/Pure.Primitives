using Pure.Primitives.Abstractions.DateTime;
using Pure.Primitives.DateTime;
using Pure.Primitives.Number;
using Pure.Primitives.Random.DateTime;
using Pure.Primitives.Time;

namespace Pure.Primitives.Tests.DateTime;

public sealed record MaterializedDateTimeTests
{
    [Fact]
    public void MaterializeCorrectly()
    {
        IEnumerable<IDateTime> randomDateTimes = new RandomDateTimeCollection(new UShort(100)).ToArray();

        IEnumerable<System.DateTime> materialized = randomDateTimes.Select(x => new MaterializedDateTime(x).Value);
        IEnumerable<System.DateTime> dateTimes = randomDateTimes.Select(x => 
            new System.DateTime(x.Year.NumberValue, 
                x.Month.NumberValue,
                x.Day.NumberValue, 
                x.Hour.NumberValue, 
                x.Minute.NumberValue,
                x.Second.NumberValue, 
                x.Millisecond.NumberValue,
                x.Microsecond.NumberValue));

        Assert.Equal(dateTimes, materialized);
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new MaterializedTime(new CurrentTime()).GetHashCode());
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new MaterializedTime(new CurrentTime()).ToString());
    }
}