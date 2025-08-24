using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Abstractions.Number;
using System;

namespace Pure.Primitives.Date;

internal sealed record DateValidState : IBool
{
    private readonly Lazy<bool> _value;

    public DateValidState(INumber<ushort> day, INumber<ushort> month, INumber<ushort> year)
        : this(
            new Lazy<bool>(() =>
            {
                try
                {
                    _ = new DateOnly(year.NumberValue, month.NumberValue, day.NumberValue);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            })
        )
    { }

    private DateValidState(Lazy<bool> value)
    {
        _value = value;
    }

    public bool BoolValue => _value.Value;
}