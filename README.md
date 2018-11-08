# NetCoreExtensions

A set of extensions to make working with some of the base class libraries easier.

[![Build status](https://ci.appveyor.com/api/projects/status/gxfnvkayfbrmllt0/branch/master?svg=true)](https://ci.appveyor.com/project/gregmac/netcoreextensions/branch/master) [![NuGet](https://img.shields.io/nuget/v/NetCoreExtensions.svg?maxAge=3600)](https://www.nuget.org/packages/NetCoreExtensions/)


## Strings

| `using NetCoreExtensions.Strings`                 | Equivalent to                                               |
| ------------------------------------------------- | ----------------------------------------------------------- |
| `value.IsNullOrEmpty()`                           | `string.IsNullOrEmpty(value)`                               |
| `value.IsNotNullOrEmpty()`                        | `!string.IsNullOrEmpty(value)`                              |
| `value.IsNullOrWhitespace()`                      | `string.IsNullOrWhitespace(value)`                          |
| `value.IsNotNullOrWhitespace()`                   | `!string.IsNullOrWhitespace(value)`                         |
| `values.Join(separator)`                          | `string.Join(separator, values)`                            |
| `value.DefaultIfNullOrEmpty(defaultValue)`        | `string.IsNullOrEmpty(value) ? defaultValue : value`        |
| `value.DefaultIfNullOrEmpty(callback)`            | `string.IsNullOrEmpty(value) ? callback() : value`          |
| `value.DefaultIfNullOrWhitespace(defaultValue)`   | `string.IsNullOrWhitespace(value) ? defaultValue : value`   |
| `value.DefaultIfNullOrWhitespace(callback)`       | `string.IsNullOrWhitespace(value) ? callback() : value`     |

## Regular Expressions

| `using NetCoreExtensions.Regex`                                 | Equivalent to                                                          |
| --------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `value.Match(pattern)`                                          | `Regex.Match(value, pattern)`                                          |
| `value.Match(pattern,options)`                                  | `Regex.Match(value, pattern,options)`                                  |
| `if (value.TryMatch(pattern, out var match)) { .. }`            | `var match = Regex.Match(value,pattern); if (match) { .. }`            |
| `if (value.TryMatch(pattern, options, out var match)) { .. }`   | `var match = Regex.Match(value,pattern, options); if (match) { .. }`   |
| `foreach (var match in value.Matches(pattern)) { .. } `         | `foreach (Match match in Regex.Matches(value, pattern)) { .. } `       |

## Hashing

`using NetCoreExtensions.Security`

* `Sha1()`, `Sha256()`, `Sha384()`, `Sha512()` methods for `string` and `byte[]`
* Return unix-style checksums, eg: `"b444ac06613fc8d63795be9ad0beaf55011936ac"`
* Defaults to `Encoding.UTF8` but can be overridden

## Date/Time

| `using NetCoreExtensions.Regex`   | Equivalent to                         |
| --------------------------------- | ------------------------------------- |
| `42.Milliseconds()`               | `TimeSpan.FromMilliseconds(45)`       |
| `42.Seconds()`                    | `TimeSpan.FromSeconds(45)`            |
| `42.Minutes()`                    | `TimeSpan.FromMinutes(45)`            |
| `42.Hours()`                      | `TimeSpan.FromHours(45)`              |
| `42.Days()`                       | `TimeSpan.FromDays(45)`               |
| `42.Ticks()`                      | `TimeSpan.FromTicks(45)`              |

 * `TimeSpan.From` aliases work with `int`, `long` or `double`.

## Enum

| `using NetCoreExtensions.Enum`        | Equivalent to                         |
| ------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `MyEnum.Val.GetName()`                | `Enum.GetName(typeof(MyEnum), MyEnum.Val)`                                                     |


## License

This project is licensed under the [MIT License](LICENSE.md).
