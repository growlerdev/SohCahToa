# SohCahToa

![GitHub Release](https://img.shields.io/github/v/release/growlerdev/sohcahtoa?display_name=release&logo=github&label=release&link=https%3A%2F%2Fgithub.com%2Fgrowlerdev%2FSohCahToa%2Freleases)
    ![GitHub Release](https://img.shields.io/github/v/release/growlerdev/sohcahtoa?include_prereleases&display_name=release&logo=github&label=latest%20build&link=https%3A%2F%2Fgithub.com%2Fgrowlerdev%2FSohCahToa%2Freleases)
    ![NuGet Downloads](https://img.shields.io/nuget/dt/sohcahtoa?logo=nuget&color=9932CC)
    ![GitHub License](https://img.shields.io/github/license/growlerdev/sohcahtoa?color=salmon)
    ![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/growlerdev/sohcahtoa/main.yml?logo=githubactions&logoColor=white&label=Build%20and%20Deploy&link=https%3A%2F%2Fgithub.com%2Fgrowlerdev%2FSohCahToa%2Factions%2Fworkflows%2Fbuild-deploy.yml)

`SohCahToa` is a C# library designed to simplify trigonometric calculations for right triangles with a focus on ease of use and precision. Named after the classic mnemonic **SOH CAH TOA** (Sine = Opposite/Hypotenuse, Cosine = Adjacent/Hypotenuse, Tangent = Opposite/Adjacent), this library provides intuitive methods for solving common trigonometry problems in engineering, construction, navigation, and educational applications.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Quick Start](#quick-start)
- [API Overview](#api-overview)
- [Method Naming Convention](#method-naming-convention)
- [Examples](#examples)
- [Performance Considerations](#performance-considerations)
- [Compatibility](#compatibility)
- [Contributing](#contributing)
- [License](#license)

## Features

- **High Precision Calculations**: Utilize double precision (`Trig`) or single precision (`TrigF`) for trigonometric operations.
- **Static Methods**: Direct access to trigonometric calculations without needing to instantiate classes.
- **Comprehensive Coverage**: Methods for calculating side lengths, primary and complementary angles in right triangles.
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
- Methods include `Rise_RunPrimaryAngle`, `PrimaryAngle_RiseRun`, `ComplementaryAngle_PrimaryAngle`, etc.

### `TrigF` Class

- **Single Precision**: Optimized for performance and memory efficiency (available in .NET Standard 2.1+).
- Methods mirror those of `Trig` but use `float` types, e.g., `Rise_RunPrimaryAngle(float run, float primaryAngle)`.

## Method Naming Convention

The library uses two naming conventions to accommodate different preferences:

### Descriptive Method Names
- **Pattern**: `{Output}_{Input1}{Input2}`
- **Examples**: 
  - `Rise_RunPrimaryAngle(run, angle)` - Calculate rise (opposite side) from run (adjacent side) and primary angle
  - `Hypotenuse_RiseRun(rise, run)` - Calculate hypotenuse from rise and run
  - `PrimaryAngle_RiseRun(rise, run)` - Calculate primary angle from rise and run

### Mathematical Aliases
- **Pattern**: `{a|b|c}_{known_values}{known_angles}`
- **Triangle notation**: `a` = opposite side (rise), `b` = adjacent side (run), `c` = hypotenuse
- **Angle notation**: `AA` = primary angle, `BB` = complementary angle
- **Examples**:
  - `a_bAA(b, AA)` - Same as `Rise_RunPrimaryAngle(run, primaryAngle)`
  - `c_ab(a, b)` - Same as `Hypotenuse_RiseRun(rise, run)`
  - `AA_ab(a, b)` - Same as `PrimaryAngle_RiseRun(rise, run)`

## Examples

### Calculate Side Lengths

```csharp
// Find the height of a building using distance and angle of elevation
double distanceFromBuilding = 50; // meters
double angleOfElevation = 30; // degrees
double buildingHeight = Trig.Rise_RunPrimaryAngle(distanceFromBuilding, angleOfElevation);
Console.WriteLine($"Building height: {buildingHeight:F2} meters");
```

### Calculate Angles

```csharp
// Find the angle of a roof slope given rise and run
double riseOfRoof = 3; // meters
double runOfRoof = 4; // meters
double roofAngle = Trig.PrimaryAngle_RiseRun(riseOfRoof, runOfRoof);
Console.WriteLine($"Roof angle: {roofAngle:F2} degrees");
```

### Using Mathematical Aliases

```csharp
// Same calculations using mathematical notation
double height = Trig.a_bAA(50, 30); // a = rise, b = run, AA = primary angle
double angle = Trig.AA_ab(3, 4);    // AA = primary angle, a = rise, b = run
```

### Comprehensive Navigation Example

```csharp
// Calculate distance traveled when hiking up a mountain trail
double horizontalDistance = 1000; // meters
double elevation = 45; // degrees
double trailDistance = Trig.Hypotenuse_RunPrimaryAngle(horizontalDistance, elevation);
double verticalRise = Trig.Rise_RunPrimaryAngle(horizontalDistance, elevation);

Console.WriteLine($"Trail distance: {trailDistance:F2} meters");
Console.WriteLine($"Elevation gain: {verticalRise:F2} meters");
```

### Single Precision for Performance-Critical Applications

```csharp
// Using TrigF for game development or real-time calculations (.NET Standard 2.1+)
float playerX = 10.0f;
float playerY = 15.0f;
float distance = TrigF.Hypotenuse_RiseRun(playerY, playerX);
float angle = TrigF.PrimaryAngle_RiseRun(playerY, playerX);
```

## Performance Considerations

- **Use `Trig` class** when you need maximum precision for scientific calculations, engineering applications, or when working with large numbers where precision is critical.
- **Use `TrigF` class** when performance and memory efficiency are priorities, such as in game development, real-time simulations, or when processing large datasets where slight precision loss is acceptable.
- **Note**: `TrigF` class is only available in .NET Standard 2.1 and later versions.

## Compatibility

- **.NET Standard 2.0+**: Full support for `Trig` class (double precision)
- **.NET Standard 2.1+**: Full support for both `Trig` and `TrigF` classes
- **Angles**: All angle inputs and outputs are in degrees (not radians)
- **Thread Safety**: All methods are static and thread-safe

## Contributing

Contributions are welcome! Please submit pull requests or open issues to discuss proposed changes or report bugs.

## License

`SohCahToa` is released under the MIT License. See the LICENSE file in the repository for more details.
