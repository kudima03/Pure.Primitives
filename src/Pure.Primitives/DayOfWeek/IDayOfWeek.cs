using Pure.Primitives.Number.Base;

namespace Pure.Primitives.DayOfWeek;

public interface IDayOfWeek
{
    internal INumber<int> DayNumber { get; }
}