using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Char;
using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Abstractions.DateTime;
using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Abstractions.Time;

namespace Pure.Primitives.String;

public sealed record String : IString
{
    private readonly Lazy<string> _lazyValue;

    public String(IBool value)
        : this(new Lazy<string>(value.BoolValue.ToString)) { }

    public String(IChar value)
        : this(new Lazy<string>(value.CharValue.ToString)) { }

    public String(IDate value)
        : this(
            new Lazy<string>(() =>
                $"{value.Month.NumberValue}/{value.Day.NumberValue}/{value.Year.NumberValue}"
            )
        )
    { }

    public String(IDateTime value)
        : this(
            new Lazy<string>(() =>
                $"{value.Month.NumberValue}/{value.Day.NumberValue}/{value.Year.NumberValue} {value.Hour.NumberValue}:{value.Minute.NumberValue}:{value.Second.NumberValue}.{value.Millisecond.NumberValue}.{value.Nanosecond.NumberValue}"
            )
        )
    { }

    public String(ITime value)
        : this(
            new Lazy<string>(() =>
                $"{value.Hour.NumberValue}:{value.Minute.NumberValue}:{value.Second.NumberValue}.{value.Millisecond.NumberValue}.{value.Nanosecond.NumberValue}"
            )
        )
    { }

    public String(IDayOfWeek value)
        : this(
            new Lazy<string>(() =>
                value.DayNumberValue.NumberValue switch
                {
                    1 => "Monday",
                    2 => "Tuesday",
                    3 => "Wednesday",
                    4 => "Thursday",
                    5 => "Friday",
                    6 => "Saturday",
                    7 => "Sunday",
                    // stryker disable once String
                    _ => throw new ArgumentException(
                        $"{nameof(IDayOfWeek.DayNumberValue)} is out of range."
                    ),
                }
            )
        )
    { }

    public String(IGuid value)
        : this(new Lazy<string>(value.GuidValue.ToString)) { }

    public String(INumber<decimal> value)
        : this(
            new Lazy<string>(() =>
                value.NumberValue.ToString(CultureInfo.InvariantCulture)
            )
        )
    { }

    public String(INumber<double> value)
        : this(
            new Lazy<string>(() =>
                value.NumberValue.ToString(CultureInfo.InvariantCulture)
            )
        )
    { }

    public String(INumber<float> value)
        : this(
            new Lazy<string>(() =>
                value.NumberValue.ToString(CultureInfo.InvariantCulture)
            )
        )
    { }

    public String(INumber<int> value)
        : this(
            new Lazy<string>(() =>
                value.NumberValue.ToString(CultureInfo.InvariantCulture)
            )
        )
    { }

    public String(INumber<long> value)
        : this(
            new Lazy<string>(() =>
                value.NumberValue.ToString(CultureInfo.InvariantCulture)
            )
        )
    { }

    public String(INumber<short> value)
        : this(
            new Lazy<string>(() =>
                value.NumberValue.ToString(CultureInfo.InvariantCulture)
            )
        )
    { }

    public String(INumber<uint> value)
        : this(
            new Lazy<string>(() =>
                value.NumberValue.ToString(CultureInfo.InvariantCulture)
            )
        )
    { }

    public String(INumber<ulong> value)
        : this(
            new Lazy<string>(() =>
                value.NumberValue.ToString(CultureInfo.InvariantCulture)
            )
        )
    { }

    public String(INumber<ushort> value)
        : this(
            new Lazy<string>(() =>
                value.NumberValue.ToString(CultureInfo.InvariantCulture)
            )
        )
    { }

    public String(string value)
        : this(new Lazy<string>(() => value)) { }

    private String(Lazy<string> lazyValue)
    {
        _lazyValue = lazyValue;
    }

    public string TextValue => _lazyValue.Value;

    public IEnumerator<IChar> GetEnumerator()
    {
        return _lazyValue.Value.Select(symbol => new Char.Char(symbol)).GetEnumerator();
    }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
