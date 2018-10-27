using System;
using System.Collections.Generic;

namespace NetCoreExtensions.Strings
{
    public static class StringExtensions
    {
        /// <summary>
        /// Alias to <see cref="string.IsNullOrEmpty">string.IsNullOrEmpty(value)</see>.
        /// </summary>
        /// <example><code>
        /// if (myValue.IsNullOrEmpty()) ... 
        /// </code></example>
        /// <param name="value">The value to test</param>
        /// <returns>True if the value is null or empty</returns>
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
        
        /// <summary>
        /// Alias to !<see cref="string.IsNullOrEmpty">string.IsNullOrEmpty(value)</see>.
        /// </summary>
        /// <example><code>
        /// if (myValue.IsNotNullOrEmpty()) ... 
        /// </code></example>
        /// <param name="value">The value to test</param>
        /// <returns>True if the value is not null or empty</returns>
        public static bool IsNotNullOrEmpty(this string value) => !string.IsNullOrEmpty(value);
        
        /// <summary>
        /// Alias to <see cref="string.IsNullOrWhiteSpace">string.IsNullOrWhiteSpace(value)</see>.
        /// </summary>
        /// <example><code>
        /// if (myValue.IsNullOrEmpty()) ... 
        /// </code></example>
        /// <param name="value">The value to test</param>
        /// <returns>True if the value is null or whitespace</returns>
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
        
        /// <summary>
        /// Alias to !<see cref="string.IsNullOrWhiteSpace">string.IsNullOrWhiteSpace(value)</see>.
        /// </summary>
        /// <example><code>
        /// if (myValue.IsNotNullOrWhiteSpace()) ... 
        /// </code></example>
        /// <param name="value">The value to test</param>
        /// <returns>True if the value is not null or whitespace</returns>
        public static bool IsNotNullOrWhiteSpace(this string value) => !string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// Alias to <see cref="string.Join(string,System.Collections.Generic.IEnumerable{string})">string.Join(separator,values)</see>
        /// </summary>
        /// <param name="values">Values to join</param>
        /// <param name="separator">Separator between items</param>
        /// <typeparam name="T">Type of data to join. Note non-strings will be converted using <see cref="object.ToString"/></typeparam>
        /// <returns></returns>
        public static string Join<T>(this IEnumerable<T> values, string separator) => string.Join(separator, values);

        /// <summary>
        /// Returns a default value is the string is null or empty.
        /// Equivalent to <code>string.IsNullOrEmpty(value) ? defaultValue : value</code>
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <param name="defaultValue">The default value, if empty</param>
        /// <returns></returns>
        public static string DefaultIfNullOrEmpty(this string value, string defaultValue)
            => string.IsNullOrEmpty(value) ? defaultValue : value;
        
        /// <summary>
        /// Returns a default value (obtained via callback) is the string is null or empty.
        /// Equivalent to <code>string.IsNullOrEmpty(value) ? defaultValue() : value</code>
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <param name="defaultValueCallback">The method to get the default value, if empty</param>
        /// <returns></returns>
        public static string DefaultIfNullOrEmpty(this string value, Func<string> defaultValueCallback)
            => string.IsNullOrEmpty(value) ? defaultValueCallback.Invoke() : value;
        
        /// <summary>
        /// Returns a default value is the string is null or whitespace.
        /// Equivalent to <code>string.IsNullOrWhitespace(value) ? defaultValue : value</code>
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <param name="defaultValue">The default value, if empty</param>
        /// <returns></returns>
        public static string DefaultIfNullOrWhitespace(this string value, string defaultValue)
            => string.IsNullOrWhiteSpace(value) ? defaultValue : value;
    
        /// <summary>
        /// Returns a default value (obtained via callback) is the string is null or empty.
        /// Equivalent to <code>string.IsNullOrWhitespace(value) ? defaultValue() : value</code>
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <param name="defaultValueCallback">The method to get the default value, if empty</param>
        /// <returns></returns>
        public static string DefaultIfNullOrWhitespace(this string value, Func<string> defaultValueCallback)
            => string.IsNullOrWhiteSpace(value) ? defaultValueCallback.Invoke() : value;
        
    }
}