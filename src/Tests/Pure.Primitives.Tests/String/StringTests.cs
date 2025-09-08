using System.Collections;
using System.Globalization;
using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Abstractions.DateTime;
using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Bool;
using Pure.Primitives.DayOfWeek;
using Pure.Primitives.Number;
using Pure.Primitives.Random.Char;
using Pure.Primitives.Random.Date;
using Pure.Primitives.Random.DateTime;
using Pure.Primitives.Random.Number;
using Pure.Primitives.Random.Time;

namespace Pure.Primitives.Tests.String;

using String = Primitives.String.String;

public sealed record StringTests
{
    [Fact]
    public void InitializeFromBool()
    {
        IBool value = new False();
        IString parsed = new String(value);
        Assert.Equal(value.BoolValue.ToString(), parsed.TextValue);
    }

    [Fact]
    public void InitializeFromChar()
    {
        IChar value = new RandomChar();
        IString parsed = new String(value);
        Assert.Equal(value.CharValue.ToString(), parsed.TextValue);
    }

    [Fact]
    public void InitializeFromDate()
    {
        IDate value = new RandomDate();
        IString parsed = new String(value);
        Assert.Equal(
            $"{value.Month.NumberValue}/{value.Day.NumberValue}/{value.Year.NumberValue}",
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromDateTime()
    {
        IDateTime value = new RandomDateTime();
        IString parsed = new String(value);
        Assert.Equal(
            $"{value.Month.NumberValue}/{value.Day.NumberValue}/{value.Year.NumberValue} {value.Hour.NumberValue}:{value.Minute.NumberValue}:{value.Second.NumberValue}.{value.Millisecond.NumberValue}.{value.Nanosecond.NumberValue}",
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromTime()
    {
        ITime value = new RandomTime();
        IString parsed = new String(value);
        Assert.Equal(
            $"{value.Hour.NumberValue}:{value.Minute.NumberValue}:{value.Second.NumberValue}.{value.Millisecond.NumberValue}.{value.Nanosecond.NumberValue}",
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromMonday()
    {
        IDayOfWeek value = new Monday();
        IString parsed = new String(value);
        Assert.Equal("Monday", parsed.TextValue);
    }

    [Fact]
    public void InitializeFromTuesday()
    {
        IDayOfWeek value = new Tuesday();
        IString parsed = new String(value);
        Assert.Equal("Tuesday", parsed.TextValue);
    }

    [Fact]
    public void InitializeFromWednesday()
    {
        IDayOfWeek value = new Wednesday();
        IString parsed = new String(value);
        Assert.Equal("Wednesday", parsed.TextValue);
    }

    [Fact]
    public void InitializeFromThursday()
    {
        IDayOfWeek value = new Thursday();
        IString parsed = new String(value);
        Assert.Equal("Thursday", parsed.TextValue);
    }

    [Fact]
    public void InitializeFromFriday()
    {
        IDayOfWeek value = new Friday();
        IString parsed = new String(value);
        Assert.Equal("Friday", parsed.TextValue);
    }

    [Fact]
    public void InitializeFromSaturday()
    {
        IDayOfWeek value = new Saturday();
        IString parsed = new String(value);
        Assert.Equal("Saturday", parsed.TextValue);
    }

    [Fact]
    public void InitializeFromSunday()
    {
        IDayOfWeek value = new Sunday();
        IString parsed = new String(value);
        Assert.Equal("Sunday", parsed.TextValue);
    }

    [Fact]
    public void InitializeFromGuid()
    {
        IGuid value = new Primitives.Guid.Guid();
        IString parsed = new String(value);
        Assert.Equal(value.GuidValue.ToString(), parsed.TextValue);
    }

    [Fact]
    public void InitializeFromDecimal()
    {
        INumber<decimal> value = new RandomDecimal();
        IString parsed = new String(value);
        Assert.Equal(
            value.NumberValue.ToString(CultureInfo.InvariantCulture),
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromDouble()
    {
        INumber<double> value = new RandomDouble();
        IString parsed = new String(value);
        Assert.Equal(
            value.NumberValue.ToString(CultureInfo.InvariantCulture),
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromFloat()
    {
        INumber<float> value = new RandomFloat();
        IString parsed = new String(value);
        Assert.Equal(
            value.NumberValue.ToString(CultureInfo.InvariantCulture),
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromInt()
    {
        INumber<int> value = new RandomInt();
        IString parsed = new String(value);
        Assert.Equal(
            value.NumberValue.ToString(CultureInfo.InvariantCulture),
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromLong()
    {
        INumber<long> value = new Long(10);
        IString parsed = new String(value);
        Assert.Equal(
            value.NumberValue.ToString(CultureInfo.InvariantCulture),
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromShort()
    {
        INumber<short> value = new MaxShort();
        IString parsed = new String(value);
        Assert.Equal(
            value.NumberValue.ToString(CultureInfo.InvariantCulture),
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromUint()
    {
        INumber<uint> value = new RandomUInt();
        IString parsed = new String(value);
        Assert.Equal(
            value.NumberValue.ToString(CultureInfo.InvariantCulture),
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromUlong()
    {
        INumber<ulong> value = new MaxUlong();
        IString parsed = new String(value);
        Assert.Equal(
            value.NumberValue.ToString(CultureInfo.InvariantCulture),
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromUshort()
    {
        INumber<ushort> value = new RandomUShort();
        IString parsed = new String(value);
        Assert.Equal(
            value.NumberValue.ToString(CultureInfo.InvariantCulture),
            parsed.TextValue
        );
    }

    [Fact]
    public void InitializeFromScalarConstructor()
    {
        const string testValue = "Test Value";
        IString stringPrimitive = new String(testValue);
        Assert.Equal(testValue, stringPrimitive.TextValue);
    }

    [Fact]
    public void EnumeratesAsTyped()
    {
        const string testValue = "Test Value";
        IEnumerable<IChar> stringPrimitive = new String(testValue);
        Assert.True(testValue.SequenceEqual(stringPrimitive.Select(x => x.CharValue)));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        const string testValue = "Test Value";

        IEnumerable stringPrimitive = new String(testValue);

        ICollection<IChar> symbols = [];

        foreach (object symbol in stringPrimitive)
        {
            symbols.Add((symbol as IChar)!);
        }

        Assert.True(testValue.SequenceEqual(symbols.Select(x => x.CharValue)));
    }

    [Fact]
    public void ThrowExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new String("Test Value").GetHashCode()
        );
    }

    [Fact]
    public void ThrowExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new String("Test Value").ToString()
        );
    }
}
