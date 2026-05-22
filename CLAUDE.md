# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

All `dotnet` commands must be run from the `./src` directory.

```bash
dotnet restore
dotnet build --no-restore -warnaserror
dotnet format --verify-no-changes             # check code style (CI enforces this)
dotnet format && csharpier format .           # auto-fix code style
dotnet test --no-build                        # run xUnit tests (requires prior build)
dotnet pack --configuration Release -p:PackageVersion=<version> --output .
```

The test project targets `net10.0` only. Code coverage is collected by `coverlet`; CI enforces a minimum of 98% line and branch coverage.

## Architecture

This is an **implementation NuGet library** — concrete `sealed record` types that implement the interfaces from `Pure.Primitives.Abstractions`. There are no abstractions defined here; every public type is a leaf implementation.

**Type categories and namespaces:**
- `Pure.Primitives.Bool` — `True`, `False`
- `Pure.Primitives.Char` — `Char`
- `Pure.Primitives.Number` — `Int`, `Long`, `Short`, `UInt`, `ULong`, `UShort`, `Double`, `Float`, `Decimal`, `Zero`, plus `Min*`/`Max*` boundary constants for each numeric type
- `Pure.Primitives.Date` — `Date`, `CurrentDate`, and `*ValidState` types (each implements `IBool`)
- `Pure.Primitives.Time` — `Time`, `CurrentTime`, and `*ValidState` types
- `Pure.Primitives.DateTime` — `DateTime`, `CurrentDateTime`
- `Pure.Primitives.DayOfWeek` — one record per day of the week (`Monday`…`Sunday`)
- `Pure.Primitives.Guid` — `Guid`, `EmptyGuid`, `Ulid`
- `Pure.Primitives.String` — `String` (converts any Pure interface to text) and named string constants (`EmptyString`, `ColonString`, etc.)

**Implementation pattern:** every record holds a `private readonly Lazy<T>` field; the public property evaluates it. `GetHashCode` and `ToString` are overridden to `throw new NotSupportedException()` — record structural equality is intentionally disabled.

**Composition:** constructors accept other Pure interfaces (e.g., `String(IDate)`, `Int(INumber<ushort>)`), so values can be composed without unwrapping to raw .NET types.

**Multi-targeting:** net7.0, net8.0, net9.0, net10.0. `IsAotCompatible = true` — no reflection or dynamic code.

**Publishing:** triggered by pushing a semver tag (`*.*.*`). The tag value becomes `PackageVersion`. Packages are pushed to both GitHub Packages and NuGet.org (requires `NUGET_API_KEY` secret).

## Code Style

Enforced via `.editorconfig` and `dotnet format --verify-no-changes` in CI:

- No `var` — always use explicit types (`csharp_style_var_*` = false)
- No expression-bodied methods or constructors; expression-bodied properties are required
- File-scoped namespaces (`csharp_style_namespace_declarations = file_scoped`)
- Private fields: `_camelCase` prefix
- Braces always required (`csharp_prefer_braces = true`)
- `System.*` usings sorted first; all usings outside namespace
- Max line length: 90 characters

## Commit Messages

Do not mention Claude or AI assistance in commit messages.
