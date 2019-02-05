# NetCoreExtensions

A set of extensions to make working with some of the base class libraries easier.

[![Build status](https://ci.appveyor.com/api/projects/status/gxfnvkayfbrmllt0/branch/master?svg=true)](https://ci.appveyor.com/project/gregmac/netcoreextensions/branch/master) [![NuGet](https://img.shields.io/nuget/v/NetCoreExtensions.svg?maxAge=3600)](https://www.nuget.org/packages/NetCoreExtensions/)

* [Documentation](#documentation)
  * [Strings](#strings)
  * [Regular Expressions](#regular-expressions)
  * [Tasks](#tasks)
  * [Hashing](#hashing)
  * [Date/Time](#datetime)
  * [Enums](#enums)
* [License](#license)


# Documentation

## Strings

`using NetCoreExtensions.Strings`

### Shortcuts to static string methods

* `value.IsNullOrEmpty()`        
* `value.IsNotNullOrEmpty()`     
* `value.IsNullOrWhitespace()`   
* `value.IsNotNullOrWhitespace()`
* `values.Join(separator)`       

### Whitespace/Empty defaults

* `value.EmptyToNull()`
* `value.WhiteSpaceToNull()`

Example: `(" ".WhiteSpaceToNull() ?? "default") == "default"`

## Regular Expressions

`using NetCoreExtensions.Regex`

### Shortcuts to static methods

* `value.Match(pattern)` 
* `value.Match(pattern, options)`

```
var name = "My Name";
if (name.Match("^my", RegexOptions.IgnoreCase)) {
    // ...
}
```


### TryMatch 

* `if (value.TryMatch(pattern, out var match)) { .. }` 
* `if (value.TryMatch(pattern, options, out var match)) { .. }`  

```
var name = "My name is foo";
if (name.Match("my name is (?<name>[A-Za-z ]+)", out var match)) {
    Console.WriteLine(match.Groups["name"].Value); // displays "foo"
}
```


### Typed Enumeration of Match results

When using `Matches`, returns a `IEnumerable<Match>` instead of `MatchCollection`,
 which means there is no need to do an explicit cast to `Match`.

```
foreach (var match in value.Matches(pattern)) { 
    Console.WriteLine(match.Value); 
}
```

## Tasks


### Task Timeout

Wrap async methods or tasks that don't provide timeout or cancelation support.

```
try { 

    var result1 = await SomethingAsync().TimeoutAfter(100);

    var result2 = await SomethingElseAsync().TimeoutAfter(1200, cancellationToken);

} catch (TaskCancelationException) {
    Console.WriteLine("Execution was canceled");
} catch (TaskTimeoutException ex) {
    Console.WriteLine($"Task timed out after {ex.Timeout}");
}
```

## Hashing

`using NetCoreExtensions.Security`

* `Sha1()`, `Sha256()`, `Sha384()`, `Sha512()`, `HmacSha1()`, `HmacSha256()`, `HmacSha384()`, `HmacSha512()`methods for `string` and `byte[]`
* Return unix-style checksums, eg: `"b444ac06613fc8d63795be9ad0beaf55011936ac"`
* Defaults to `Encoding.UTF8` for `string` inputs but can be overridden

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


## Enums

`using NetCoreExtensions.Enum`

### Get Names

* `MyEnum.Val1.GetName()`

### String/Integer conversion

* `42.ToEnum<MyEnum>()` returns `Nullable<MyEnum>(null)` if invalid
* `42.ToEnum(defaultValue)` returns `defaultValue` if invalid
* `"Val1".ToEnum<MyEnum>()` returns `Nullable<MyEnum>` if invalid
* `"Val1".ToEnum(defaultValue)` returns `defaultValue` if invalid

# License

This project is licensed under the [MIT License](LICENSE.md).
