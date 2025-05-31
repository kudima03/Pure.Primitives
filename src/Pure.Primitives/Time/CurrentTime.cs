using Pure.Primitives.Abstractions.Number;
using Pure.Primitives.Abstractions.Time;
using Pure.Primitives.Number;
using System;

namespace Pure.Primitives.Time;

public sealed record CurrentTime : ITime
{
    public INumber<ushort> Hour { get; } = new UShort((ushort)System.DateTime.Now.Hour);

    public INumber<ushort> Minute { get; } = new UShort((ushort)System.DateTime.Now.Minute);

    public INumber<ushort> Second { get; } = new UShort((ushort)System.DateTime.Now.Second);

    public INumber<ushort> Millisecond { get; } = new UShort((ushort)System.DateTime.Now.Millisecond);

    public INumber<ushort> Microsecond { get; } = new UShort((ushort)System.DateTime.Now.Microsecond);

    public INumber<ushort> Nanoseconds { get; } = new UShort((ushort)System.DateTime.Now.Nanosecond);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}