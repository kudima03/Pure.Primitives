# Pure.Primitives

Concrete implementations of immutable, composable primitive types for the **Pure** ecosystem — type-safe wrappers over .NET primitive types with full AOT compatibility.

[![.NET build & test](https://github.com/kudima03/Pure.Primitives/actions/workflows/build-and-check.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives/actions/workflows/build-and-check.yml)
[![NuGet publish](https://github.com/kudima03/Pure.Primitives/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Primitives)](https://www.nuget.org/packages/Pure.Primitives)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE.txt)

## Overview

`Pure.Primitives` provides `sealed record` implementations of every interface defined in [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions). Each type wraps a single .NET primitive value with lazy evaluation, is immutable by design, and exposes no mutation surface. All types implement `GetHashCode` and `ToString` as `throw new NotSupportedException()` — equality and formatting flow through the underlying value, not the wrapper.

## Types

### Bool

| Type | Implements | Description |
|------|-----------|-------------|
| `True` | `IBool` | Singleton representing `true` |
| `False` | `IBool` | Singleton representing `false` |

### Char

| Type | Implements | Description |
|------|-----------|-------------|
| `Char` | `IChar` | Single Unicode character |

### Number (`INumber<T>`)

| Type | Underlying type |
|------|----------------|
| `Int` | `int` |
| `Long` | `long` |
| `Short` | `short` |
| `UInt` | `uint` |
| `ULong` | `ulong` |
| `UShort` | `ushort` |
| `Double` | `double` |
| `Float` | `float` |
| `Decimal` | `decimal` |
| `Zero` | generic `0` |
| `MinInt` / `MaxInt` | `int.MinValue` / `int.MaxValue` |
| `MinLong` / `MaxLong` | `long.MinValue` / `long.MaxValue` |
| `MinShort` / `MaxShort` | `short.MinValue` / `short.MaxValue` |
| `MinDouble` / `MaxDouble` | `double.MinValue` / `double.MaxValue` |
| `MinFloat` / `MaxFloat` | `float.MinValue` / `float.MaxValue` |
| `MinDecimal` / `MaxDecimal` | `decimal.MinValue` / `decimal.MaxValue` |
| `MinUint` / `MaxUint` | `uint.MinValue` / `uint.MaxValue` |
| `MinUlong` / `MaxUlong` | `ulong.MinValue` / `ulong.MaxValue` |
| `MinUshort` / `MaxUshort` | `ushort.MinValue` / `ushort.MaxValue` |

### Date / Time

| Type | Implements | Description |
|------|-----------|-------------|
| `Date` | `IDate` | Composed of `INumber<ushort>` day, month, year |
| `Time` | `ITime` | Hour, minute, second, millisecond, microsecond, nanosecond |
| `DateTime` | `IDateTime` | Composite of `IDate` and `ITime` |
| `CurrentDate` | `IDate` | Today's date |
| `CurrentTime` | `ITime` | Current time |
| `CurrentDateTime` | `IDateTime` | Current date and time |
| `DateValidState` | `IBool` | Whether a `Date` value is in range |
| `TimeValidState` | `IBool` | Whether a `Time` value is in range |
| `HoursValidState` | `IBool` | Whether hours are 0–23 |
| `MinutesValidState` | `IBool` | Whether minutes are 0–59 |
| `SecondsValidState` | `IBool` | Whether seconds are 0–59 |
| `MillisecondsValidState` | `IBool` | Whether milliseconds are 0–999 |
| `MicrosecondsValidState` | `IBool` | Whether microseconds are 0–999 |
| `NanosecondsValidState` | `IBool` | Whether nanoseconds are 0–999 |

### Day of Week

`Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday` — each implements `IDayOfWeek` with `DayNumberValue` 1–7.

### Guid

| Type | Implements | Description |
|------|-----------|-------------|
| `Guid` | `IGuid` | Wraps a `System.Guid` |
| `EmptyGuid` | `IGuid` | `Guid.Empty` |
| `Ulid` | `IGuid` | ULID generated via `ByteAether.Ulid`, stored as `System.Guid` |

### String

| Type | Implements | Description |
|------|-----------|-------------|
| `String` | `IString` | Lazy `string` built from any `IBool`, `IChar`, `INumber<T>`, `IDate`, `ITime`, `IDateTime`, `IDayOfWeek`, `IGuid`, or raw `string` |
| `EmptyString` | `IString` | `""` |
| `NewLineString` | `IString` | `Environment.NewLine` |
| `WhitespaceString` | `IString` | `" "` |
| `ColonString` | `IString` | `":"` |
| `CommaString` | `IString` | `","` |
| `DotString` | `IString` | `"."` |
| `SemicolonString` | `IString` | `";"` |
| `SingleQuoteString` | `IString` | `"'"` |
| `DoubleQuoteString` | `IString` | `"\""` |
| `LeftRoundBracketString` | `IString` | `"("` |
| `RightRoundBracketString` | `IString` | `")"` |
| `LeftSquareBracketString` | `IString` | `"["` |
| `RightSquareBracketString` | `IString` | `"]"` |
| `LeftCurlyBracketString` | `IString` | `"{"` |
| `RightCurlyBracketString` | `IString` | `"}"` |

## Design Principles

- **Immutable** — no setters, no mutation; state is captured at construction time.
- **Lazy** — internal values are wrapped in `Lazy<T>`; evaluation is deferred until first access.
- **Composable** — types accept other Pure interfaces as constructor arguments, enabling composition without unwrapping.
- **AOT-compatible** — `IsAotCompatible = true`; no reflection, no dynamic code generation.

## Dependencies

- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions/tree/4.3.0) — base interfaces (`IBool`, `IChar`, `INumber<T>`, `IDate`, `ITime`, `IDateTime`, `IDayOfWeek`, `IGuid`, `IString`) that every type in this package implements

## Target Frameworks

- .NET 7
- .NET 8
- .NET 9
- .NET 10

## Installation

```bash
dotnet add package Pure.Primitives
```

## Usage

```csharp
using Pure.Primitives.Number;
using Pure.Primitives.Date;
using Pure.Primitives.String;

// Compose primitives from other primitives — no raw .NET types needed at call sites
INumber<int> count = new Int(42);
IDate today = new CurrentDate();
IString label = new String(today); // "5/22/2026" — lazy, evaluated on first access

// Boundary constants
INumber<int> max = new MaxInt(); // int.MaxValue
```
