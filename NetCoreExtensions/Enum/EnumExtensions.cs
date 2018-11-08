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

    }
}
