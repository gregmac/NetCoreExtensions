using System.Collections.Generic;

namespace NetCoreExtensions.Strings
{
    /// <summary>
    /// String related methods
    /// </summary>
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
        /// <para>Returns null if a string is empty, otherwise returns the original string.</para>
        /// <para>
        /// Allows easily assigning default values for empty strings, eg:
        /// <code>
        /// myvalue.EmptyToNull() ?? "default"
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <returns></returns>
        public static string EmptyToNull(this string value)
            => string.IsNullOrEmpty(value) ? null : value;

        /// <summary>
        /// <para>Returns null if a string is whitespace, otherwise returns the original string.</para>
        /// <para>
        /// Allows easily assigning default values for empty strings, eg:
        /// <code>
        /// myvalue.WhitespaceToNull() ?? "default"
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <returns></returns>
        public static string WhiteSpaceToNull(this string value)
            => string.IsNullOrWhiteSpace(value) ? null : value;
    }
}