# Jacobi DateTime Operators

This package implements operator extensions for `DateTime`, `DateTimeOffset`, `DateOnly`, `TimeOnly` and `TimeSpan`.

Note that all of this code is wrapper code and all operations for date-time are implemented using existing methods on the `DateTime` (and related) types. This will bring down the chance of bugs or inconsistancies.

## Key Advantages

1. **Readability**: Mathematical operations look more natural
3. **Maintainability**: Less boilerplate code
4. **Safety**: Type-safe generic constraints ensure valid operations
5. **Expressiveness**: Natural syntax for manipulating date-time

## Usage

Here are some usage examples:

```csharp
var dt = new DateTime(2025, 11, 21);
var dt1 = dt + 3.Days;
```

```csharp
var dt = new DateTime(2025, 11, 21);
var dt1 = dt - 3.M; // Months
```

```csharp
var dt = new DateTime(2025, 11, 21, 14, 42, 12);
var dt1 = dt + 7.5.Minutes; // add 7 and a half minutes
// dt1.Minute => 49 (42+7)
// dt1.Second => 42 (12+30)
```

## Type System

The library provides (value) types for every part that plays a role in manipulating date-time.

| Type | Factory | Value | Description | 
|------|---------|-------------|-------|
| `Ticks` | `t`, `Ticks` | `long` | Represents time ticks (100 nanosecond units) |
| `Microseconds` | `us`, `Microseconds` | `long`, `int` | Represents microseconds |
| `MicrosecondsF` | `us`, `Microseconds` | `double` | Represents fractional microseconds |
| `Milliseconds` | `ms`, `Milliseconds` | `long`, `int` | Represents milliseconds |
| `MillisecondsF` | `ms`, `Milliseconds` | `double` | Represents fractional milliseconds |
| `Seconds` | `s`, `Seconds` | `long`, `int` | Represents seconds |
| `SecondsF` | `s`, `Seconds` | `double` | Represents fractional seconds |
| `Minutes` | `m`, `Minutes` | `long`, `int` | Represents minutes |
| `MinutesF` | `m`, `Minutes` | `double` | Represents fractional minutes |
| `Hours` | `h`, `Hours` | `int`,  | Represents hours |
| `HoursF` | `h`, `Hours` | `double` | Represents fractional hours |
| `Days` | `d`, `Days` | `int` | Represents days |
| `DaysF` | `d`, `Days` | `double` | Represents fractional days |
| `Months` | `M`, `Months` | `int` | Represents months |
| `Years` | `y`, `Years` | `int` | Represents years |

Examples of how to use the type system:

```csharp
var years = new Years(2025)   // all value types have a value constructor
var days = 3.d;               // d extension on int returns a Days instance
var days2 = 3.Days;           // use the full name of the extension for readability/preference
var secondsFraction = 2.4.s   // s extension on double returns a SecondsF instance
var ticks = 843710982.t       // t extension on long returns a Ticks instance
```

## Operator Extensions Reference

| Types | `DateTime` | `DateTimeOffset` | `DateOnly` | `TimeOnly`* | `TimeSpan`* |
|------------|------------|------------------|------------|------------|------------|
| `Ticks`         | `+`, `-` | `+`, `-` |          |          |          |
| `Microseconds`  | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `MicrosecondsF` | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `Milliseconds`  | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `MillisecondsF` | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `Seconds`       | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `SecondsF`      | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `Minutes`       | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `MinutesF`      | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `Hours`         | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `HoursF`        | `+`, `-` | `+`, `-` |          | `+`, `-` | `+`, `-` |
| `Days`          | `+`, `-` | `+`, `-` | `+`, `-` |          | `+`, `-` |
| `DaysF`         | `+`, `-` | `+`, `-` |          |          | `+`, `-` |
| `Months`        | `+`, `-` | `+`, `-` | `+`, `-` |          |          |
| `Years`         | `+`, `-` | `+`, `-` | `+`, `-` |          |          |

> *) Some operators may introduce an additional value transformation to/from `TimeSpan`.

Note that `TimeSpan` already has several overloaded operators for primitive times and arithmetic functions.

### Extension Methods

All date-time types support `From` methods for construction with typed parameters:

```csharp
var years = new Years(2025);
var months = new Months(11);
var days = new Days(21);
var dt = DateTime.From(years, months, days);
```

> The `From` extension method for `DateTimeOffset` requires an extra offset parameter (`TimeSpan`).

Multiple overloads are available per type with different combinations of parameter types.

> Because the `DateTime` and related type already have a `Deconstruct` implementation, it could not be extended. Instead we've renamed the method to `To`.

All date-time types support `T` methods for deconstructing with typed parameters:

```csharp
var dt = DateTime.From(2025, 11, 21);
dt.To(out Years years, out Months months, out Days days);
// years => 2025
// months => 11
// days => 21
```

> The `To` extension method for `DateTimeOffset` returns the offset as a return value.

Multiple overloads are available per type with different combinations of parameter types.

---

You may also enjoy the `Jacobi.ArrayOperators` package that lets you do 'array arithmetic' using operator extensions.
