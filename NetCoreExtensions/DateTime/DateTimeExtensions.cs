using System;

namespace NetCoreExtensions.DateTime
{
    public static class DateTimeExtensions
    {
        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Milliseconds(this int value) => TimeSpan.FromMilliseconds(value);
        
        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Seconds(this int value) => TimeSpan.FromSeconds(value);
        
        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Minutes(this int value) => TimeSpan.FromMinutes(value);
        
        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Hours(this int value) => TimeSpan.FromHours(value);
        
        /// <inheritdoc cref="TimeSpan.FromDays"/>
        public static TimeSpan Days(this int value) => TimeSpan.FromDays(value);
        
        /// <inheritdoc cref="TimeSpan.FromTicks"/>
        public static TimeSpan Ticks(this int value) => TimeSpan.FromTicks(value);
    }
}