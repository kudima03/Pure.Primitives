using Pure.Primitives.Abstractions.Date;
using Pure.Primitives.Abstractions.DateTime;
using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Date;
using Pure.Primitives.Time;
using System;

namespace Pure.Primitives.DateTime;

public sealed record CurrentDateTime : IDateTime
{
    private readonly IDate _date = new CurrentDate();

    private readonly ITime _time = new CurrentTime();
    
    public INumber<ushort> Day => _date.Day;

    public INumber<ushort> Month => _date.Month;

    public INumber<ushort> Year => _date.Year;

    public INumber<ushort> Hour => _time.Hour;

    public INumber<ushort> Minute => _time.Minute;

    public INumber<ushort> Second => _time.Second;

    public INumber<ushort> Millisecond => _time.Millisecond;

    public INumber<ushort> Microsecond => _time.Microsecond;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}