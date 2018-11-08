# NetCoreExtensions

A set of extensions to make working with some of the base class libraries easier.

[![Build status](https://ci.appveyor.com/api/projects/status/gxfnvkayfbrmllt0/branch/master?svg=true)](https://ci.appveyor.com/project/gregmac/netcoreextensions/branch/master) [![NuGet](https://img.shields.io/nuget/v/NetCoreExtensions.svg?maxAge=3600)](https://www.nuget.org/packages/NetCoreExtensions/)


## Strings

`using NetCoreExtensions.Strings`

### Shortcuts to static string methods

* `value.IsNullOrEmpty()`        
* `value.IsNotNullOrEmpty()`     
* `value.IsNullOrWhitespace()`   
* `value.IsNotNullOrWhitespace()`
* `values.Join(separator)`       

### Whitespace/Empty defaults

* `value.DefaultIfNullOrEmpty(defaultValue)`     
* `value.DefaultIfNullOrEmpty(callback)`         
* `value.DefaultIfNullOrWhitespace(defaultValue)`
* `value.DefaultIfNullOrWhitespace(callback)`    

## Regular Expressions

`using NetCoreExtensions.Regex`

### Shortcuts to static methods

* `value.Match(pattern)` 
* `value.Match(pattern, options)`

### TryMatch 

* `if (value.TryMatch(pattern, out var match)) { .. }` 
* `if (value.TryMatch(pattern, options, out var match)) { .. }`  

### Typed Enumeration of Match results

No more explicit casting to `Match`!

* `foreach (var match in value.Matches(pattern)) { .. } `

## Hashing

`using NetCoreExtensions.Security`

* `Sha1()`, `Sha256()`, `Sha384()`, `Sha512()` methods for `string` and `byte[]`
* Return unix-style checksums, eg: `"b444ac06613fc8d63795be9ad0beaf55011936ac"`
* Defaults to `Encoding.UTF8` but can be overridden

## Date/Time

`using NetCoreExtensions.DateTime`

### TimeSpan.FromXXX() aliases

These work with `int`, `long` or `double`.

* `42.Milliseconds()`
* `42.Seconds()`     
* `42.Minutes()`     
* `42.Hours()`       
* `42.Days()`        
* `42.Ticks()` 


## Enum

`using NetCoreExtensions.Enum`

### Get Names

* `MyEnum.Val1.GetName()`

### String/Integer conversion

* `42.ToEnum<MyEnum>()` returns `Nullable<MyEnum>(null)` if invalid
* `42.ToEnum(defaultValue)` returns `defaultValue` if invalid
* `"Val1".ToEnum<MyEnum>()` returns `Nullable<MyEnum>` if invalid
* `"Val1".ToEnum(defaultValue)` returns `defaultValue` if invalid

## License

This project is licensed under the [MIT License](LICENSE.md).
