# SohCahToa

[![NuGet version (iAutomateDesign.AutodeskAppStore)](https://buildstats.info/nuget/SohCahToa)](https://www.nuget.org/packages/SohCahToa)

Simplifies performing Trig calculations by providing descriptive function names. No longer have to remember whether Sin, Cos, or Tan need to be used to get the value you are needing.

## How to Use

* Add a using statement for `SohCahToa`
* Call static functions within the `Trig` class


```csharp
var run = 10;
var rise = 15;
var hypotenuse = Trig.Hypotenuse_RiseRun(rise, run);
```



### Triangle Side/Angle Nomenclature:

![Triangle Labels](https://i.imgur.com/EUrjY2m.png)

* Hypotenuse = c
* Run = b
* Rise = a
* Primary Angle = AA
* Complimentary Angle = BB

**Angles are in degrees**

### Function names follow the following structure:

**[Value to be Calculated]_[Input 1][Input 2]**

For Example:

The function to use for calculating the hypotenuse of a triangle using the Rise and Run values would be `Hypotenuse_RiseRun()`

### Short Method Naming:

Alternatively, there are functions that reference the values shown in the image above that could be used instead of using the descriptive names.

* Sides are named with lower case letters (a,b,c)

* Angles are named with upper case double letters (AA, BB)

The same calculated from above, calculating the hypotenuse using the Rise and Run values would be `c_ab()`

#### Using an Angle as an Input

If an angle is used as an input for a calculation, the angle is always the first input.

For Example:

To calculate the hypotenuse using the Primary Angle and the Run would be `c_AAb`

