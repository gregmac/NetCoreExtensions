using System;

namespace NetCoreExtensions.Enum
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the string value of an Enum
        /// </summary>
        /// <typeparam name="T">The type of enum</typeparam>
        /// <param name="enumVal">The enum value</param>
        /// <returns>The string representation of the enum</returns>
        public static string GetName<T>(this T enumVal) where T : struct, System.Enum 
            => System.Enum.GetName(typeof(T), enumVal);


        /// <summary>
        /// Convert a string to an Enum value (nullable) of a specified type,
        /// or null if not valid.
        /// </summary>
        /// <typeparam name="T">The type of enum to convert</typeparam>
        /// <param name="value">The string value</param>
        /// <returns></returns>
        public static T? ToEnum<T>(this int value) where T : struct, System.Enum
            => System.Enum.IsDefined(typeof(T), value) ? (T?)System.Enum.ToObject(typeof(T), value) : null;

        /// <summary>
        /// Convert an integer value to an Enum of a specified type,
        /// with fallback to a default value if the integer is invalid.
        /// </summary>
        /// <typeparam name="T">The type of enum to convert</typeparam>
        /// <param name="value">The value</param>
        /// <param name="defaultValue">The default value to use if the integer is not in the enum</param>
        /// <returns></returns>
        public static T ToEnum<T>(this int value, T defaultValue) where T : struct, System.Enum
            => System.Enum.IsDefined(typeof(T), value) ? (T)System.Enum.ToObject(typeof(T), value) : defaultValue;

        /// <summary>
        /// Convert a string to an Enum value (nullable) of a specified type,
        /// or return null if not found.
        /// 
        /// The string can contain either a string or numeric value.
        /// </summary>
        /// <typeparam name="T">The type of enum to convert</typeparam>
        /// <param name="value">The string value</param>
        /// <param name="ignoreCase">If case should be ignored</param>
        /// <param name="defaultValue">The default value to use if the string is invalid</param>
        /// <returns></returns>
        public static T? ToEnum<T>(this string value) where T : struct, System.Enum
            => int.TryParse(value, out var intValue)
                ? intValue.ToEnum<T>()
                : System.Enum.TryParse<T>(value, out var result) ? (T?)result : null;

        /// <summary>
        /// Convert a string to an Enum value (nullable) of a specified type,
        /// or return null if not found.
        /// 
        /// The string can contain either a string or numeric value.
        /// </summary>
        /// <typeparam name="T">The type of enum to convert</typeparam>
        /// <param name="value">The string value</param>
        /// <param name="ignoreCase">If case should be ignored</param>
        /// <param name="defaultValue">The default value to use if the string is invalid</param>
        /// <returns></returns>
        public static T? ToEnum<T>(this string value, bool ignoreCase) where T : struct, System.Enum
            => int.TryParse(value, out var intValue)
                ? intValue.ToEnum<T>()
                : System.Enum.TryParse<T>(value, ignoreCase, out var result) ? (T?)result : null;


        /// <summary>
        /// Convert an integer value to an Enum of a specified type,
        /// with fallback to a default value if the integer is invalid.
        /// </summary>
        /// <typeparam name="T">The type of enum to convert</typeparam>
        /// <param name="value">The value</param>
        /// <param name="defaultValue">The default value to use if the integer is not in the enum</param>
        /// <returns></returns>
        public static T ToEnum<T>(this string value, T defaultValue) where T : struct, System.Enum
            => int.TryParse(value, out var intValue)
                ? intValue.ToEnum(defaultValue)
                : System.Enum.TryParse<T>(value, out var result) ? result : defaultValue;

        /// <summary>
        /// Convert a string to an Enum value of a specified type,
        /// with fallback to a default if the string is invalid.
        /// 
        /// The string can contain either a string or numeric value.
        /// </summary>
        /// <typeparam name="T">The type of enum to convert</typeparam>
        /// <param name="value">The string value</param>
        /// <param name="ignoreCase">If case should be ignored</param>
        /// <param name="defaultValue">The default value to use if the string is invalid</param>
        /// <returns></returns>
        public static T ToEnum<T>(this string value, bool ignoreCase, T defaultValue) where T : struct, System.Enum
            => int.TryParse(value, out var intValue)
                ? intValue.ToEnum(defaultValue)
                : System.Enum.TryParse<T>(value, ignoreCase, out var result) ? result : defaultValue;

    }
}
