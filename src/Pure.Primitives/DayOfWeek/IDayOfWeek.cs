using Pure.Primitives.Abstractions.Number;

namespace Pure.Primitives.DayOfWeek;

public interface IDayOfWeek
{
    internal INumber<int> DayNumber { get; }
}