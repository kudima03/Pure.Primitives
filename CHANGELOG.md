# Changelog

All notable changes to Pure.Primitives are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [3.6.5] — 2026-06-17

### Fixed
- `String(ITime)` and `String(IDateTime)` now render the time's microsecond value instead of duplicating nanoseconds.

## [3.6.4] — 2026-05-19

- Maintenance release: dependency and build updates.

## [3.6.3] — 2026-05-06

- Maintenance release: dependency and build updates.

## [3.6.2] — 2025-11-23

- Maintenance release: dependency and build updates.

## [3.6.1] — 2025-11-18

- Maintenance release: dependency and build updates.

## [3.6.0] — 2025-11-13

### Added
- Added `net10.0` as a target framework (the package now targets `net7.0`, `net8.0`, `net9.0`, and `net10.0`).

## [3.5.0] — 2025-11-08

### Added
- The package now multi-targets `net7.0`, `net8.0`, and `net9.0` (previously `net9.0` only).

### Changed
- `Ulid()` now generates its value using the ByteAether.Ulid library instead of `Guid.CreateVersion7()`, producing a spec-compliant ULID rather than a GUID v7 value.

## [3.4.0] — 2025-10-31

### Added
- Declared NativeAOT compatibility (`IsAotCompatible`) and enabled nullable reference type annotations for the package.

### Changed
- `Char.CharValue`, `Guid.GuidValue`, `Ulid.GuidValue`, `Decimal.NumberValue`, `Date.Day`/`Month`/`Year`, and the `DayOfWeek` implementations' `DayNumberValue` are now public properties on the concrete types instead of explicit interface implementations, so they can be read without casting to the interface.

## [3.3.0] — 2025-09-08

### Added
- Added `ColonString` and `SemicolonString` primitives.
- `String` gained constructors that convert other primitives (`IBool`, `IChar`, `IDate`, `IDateTime`, `IDayOfWeek`, `IGuid`, `INumber<T>`, `ITime`) to their string representation.

## [3.2.0] — 2025-09-05

### Added
- Added bracket, quote, and punctuation string primitives: `LeftCurlyBracketString`, `RightCurlyBracketString`, `LeftSquareBracketString`, `RightSquareBracketString`, `LeftRoundBracketString`, `RightRoundBracketString`, `DoubleQuoteString`, `SingleQuoteString`, `CommaString`, `DotString`.

## [3.1.1] — 2025-09-01

- Maintenance release: dependency and build updates.

## [3.1.0] — 2025-08-25

### Added
- Implemented `Short` and `ULong` numeric primitives, with `MinShort`/`MaxShort` and `MinUlong`/`MaxUlong` extreme-value variants.
- Added widening conversion constructors across numeric primitives (e.g. `UInt(INumber<ushort>)`, `Long(INumber<int>)`, `Double(INumber<float>)`, `Decimal(INumber<long>)`), allowing narrower numeric primitives to convert to wider ones.

### Removed
- **Breaking:** Removed the `Decimal(INumber<double>)` and `Decimal(INumber<float>)` constructors.

## [3.0.0] — 2025-06-11

### Removed
- **Breaking:** Removed all `Materialized*` primitive types (`MaterializedBool`, `MaterializedChar`, `MaterializedDate`, `MaterializedDateTime`, `MaterializedDayOfWeek`, `MaterializedGuid`, `MaterializedNumber`, `MaterializedString`, `MaterializedTime`).

## [2.0.1] — 2025-06-11

- Maintenance release: dependency and build updates.

## [2.0.0] — 2025-06-03

### Changed
- **Breaking:** `Time.Nanoseconds` (and the corresponding member on `DateTime`, `CurrentTime`, `CurrentDateTime`) renamed to `Nanosecond`.

## [1.7.0] — 2025-05-31

### Added
- Implemented the `Decimal` primitive, with `MinDecimal`/`MaxDecimal` extreme-value variants.
- Added nanosecond precision to `Time` and `DateTime` via a new `Nanoseconds` property and constructor parameter.

### Changed
- **Breaking:** `IDayOfWeek.DayNumberValue` changed from `INumber<int>` to `INumber<ushort>`.

## [1.6.1] — 2025-05-29

- Maintenance release: dependency and build updates.

## [1.6.0] — 2025-05-28

### Added
- Implemented `CurrentDate`, `CurrentTime`, and `CurrentDateTime` primitives that capture the current date and time.

## [1.5.0] — 2025-05-28

### Added
- Implemented `Date`, `Time`, `DateTime`, and `Ulid` primitives.
- Implemented `Zero<T>`, a generic zero-value primitive.

### Changed
- **Breaking:** Primitive interface value accessors renamed to type-specific names (e.g. `IBool.Value` → `BoolValue`, `INumber<T>.Value` → `NumberValue`, `IGuid.Value` → `GuidValue`).

## [1.4.0] — 2025-05-27

### Added
- Added `Min`/`Max` extreme-value primitives for `Int`, `UInt`, `Long`, `Double`, `Float`, and `UShort` (`MinInt`, `MaxInt`, `MinUint`, `MaxUint`, `MinLong`, `MaxLong`, `MinDouble`, `MaxDouble`, `MinFloat`, `MaxFloat`, `MinUshort`, `MaxUshort`).

## [1.3.0] — 2025-05-26

### Added
- `String` and its variants (`EmptyString`, `NewLineString`, `WhitespaceString`) now implement `IEnumerable<IChar>`, allowing iteration over the string's characters.

## [1.2.0] — 2025-05-26

### Added
- Implemented the `EmptyString` primitive.

## [1.1.0] — 2025-05-26

### Added
- Implemented the `WhitespaceString` and `NewLineString` primitives.

## [1.0.2] — 2025-05-26

- Maintenance release: dependency and build updates.

## [1.0.1] — 2025-05-23

- Maintenance release: dependency and build updates.

## [1.0.0] — 2025-05-23

### Removed
- **Breaking:** Removed the `Choice` primitive variants (`BoolChoice`, `CharChoice`, `DayOfWeekChoice`, `GuidChoice`, `NumberChoice`, `StringChoice`).

## [0.1.0] — 2025-05-21

### Added
- Initial release. Primitive value types with interface abstractions provided by the `Pure.Primitives.Abstractions` package: `Bool` (`True`/`False`), `Char`, `DayOfWeek` (`Monday`–`Sunday`), `Guid`, numeric types (`Int`, `UInt`, `Long`, `Float`, `Double`, `UShort`), and `String`.
- Random-value `Choice` variants for testing: `BoolChoice`, `CharChoice`, `DayOfWeekChoice`, `GuidChoice`, `NumberChoice`, `StringChoice`.
