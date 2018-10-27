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
    }
}