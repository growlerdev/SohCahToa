# SohCahToa

[![NuGet version (SohCahToa)](https://buildstats.info/nuget/SohCahToa)](https://www.nuget.org/packages/SohCahToa)

`SohCahToa` is a C# library designed to simplify trigonometric calculations with a focus on ease of use and precision.

## Features

- **High Precision Calculations**: Utilize double precision (`Trig`) or single precision (`TrigF`) for trigonometric operations.
- **Static Methods**: Direct access to trigonometric calculations without needing to instantiate classes.
- **Comprehensive Coverage**: Methods for calculating side lengths, primary and complimentary angles in right triangles.
- **Ease of Use**: Intuitive method naming convention for quick understanding and implementation.

## Installation

To integrate `SohCahToa` into your project, use the following NuGet command:

```bash
Install-Package SohCahToa
```

## Quick Start

Calculate the length of the opposite side of a right triangle given the adjacent side and the angle:

```csharp
double run = 5;
double primaryAngle = 30;
double rise = Trig.Rise_RunPrimaryAngle(run, primaryAngle);
Console.WriteLine($"Rise: {rise}");
```

## API Overview

### `Trig` Class

- **Double Precision**: For applications requiring high accuracy.
- Methods include `Rise_RunPrimaryAngle`, `PrimaryAngle_RiseRun`, `ComplimentaryAngle_PrimaryAngle`, etc.

### `TrigF` Class

- **Single Precision**: Optimized for performance and memory efficiency.
- Methods mirror those of `Trig` but use `float` types, e.g., `Rise_RunPrimaryAngle(float run, float primaryAngle)`.

### Method Naming Convention

- **Descriptive Prefix**: The primary output or focus of the method (e.g., `Rise`, `Run`, `PrimaryAngle`).
- **Underscore Separator**: Enhances readability and method parsing.
- **Input Parameters**: Inputs or known quantities used for calculation.

## Examples

### Calculate Side Lengths

```csharp
double run = 5;
double primaryAngle = 30;
double rise = Trig.Rise_RunPrimaryAngle(run, primaryAngle);
```

### Calculate Angles

```csharp
double rise = 3;
double run = 4;
double primaryAngle = Trig.PrimaryAngle_RiseRun(rise, run);
```

### Comprehensive Calculations

```csharp
double run = 5;
double primaryAngle = 30;
double rise = Trig.Rise_RunPrimaryAngle(run, primaryAngle);
double complimentaryAngle = Trig.ComplimentaryAngle_PrimaryAngle(primaryAngle);
```

## Contributing

Contributions are welcome! Please submit pull requests or open issues to discuss proposed changes or report bugs.

## License

`SohCahToa` is released under the MIT License. See the LICENSE file in the repository for more details.