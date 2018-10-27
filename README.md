# NetCoreExtensions

A set of extensions to make working with some of the base class libraries easier.


## Strings

| With Extension                    | Equivalent to                         |
| --------------------------------- | ------------------------------------- |
| `value.IsNullOrEmpty()`           | `string.IsNullOrEmpty(value)`         |
| `value.IsNotNullOrEmpty()`        | `!string.IsNullOrEmpty(value)`        |
| `value.IsNullOrWhitespace()`      | `string.IsNullOrWhitespace(value)`    |
| `value.IsNotNullOrWhitespace()`   | `!string.IsNullOrWhitespace(value)`   |

## Regular Expressions

| With Extension                                                  | Equivalent to                                                          |
| --------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `value.Match(pattern)`                                          | `Regex.Match(value, pattern)`                                          |
| `value.Match(pattern,options)`                                  | `Regex.Match(value, pattern,options)`                                  |
| `if (value.TryMatch(pattern, out var match)) { .. }`            | `var match = Regex.Match(value,pattern); if (match) { .. }`            |
| `if (value.TryMatch(pattern, options, out var match)) { .. }`   | `var match = Regex.Match(value,pattern, options); if (match) { .. }`   |
| `foreach (var match in value.Matches(pattern)) { .. } `         | `foreach (Match match in Regex.Matches(value, pattern)) { .. } `       |


## License

This project is licensed under the [MIT License](LICENSE.md).
