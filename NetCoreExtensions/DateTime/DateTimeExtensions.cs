using System;

namespace NetCoreExtensions.DateTime
{
    /// <summary>
    /// Date, Time and TimeSpan related extensions.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Milliseconds(this int value) => TimeSpan.FromMilliseconds(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Milliseconds(this long value) => TimeSpan.FromMilliseconds(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Milliseconds(this double value) => TimeSpan.FromMilliseconds(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Seconds(this int value) => TimeSpan.FromSeconds(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Seconds(this long value) => TimeSpan.FromSeconds(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Seconds(this double value) => TimeSpan.FromSeconds(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Minutes(this int value) => TimeSpan.FromMinutes(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Minutes(this long value) => TimeSpan.FromMinutes(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Minutes(this double value) => TimeSpan.FromMinutes(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Hours(this int value) => TimeSpan.FromHours(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Hours(this long value) => TimeSpan.FromHours(value);

        /// <inheritdoc cref="TimeSpan.FromMilliseconds"/>
        public static TimeSpan Hours(this double value) => TimeSpan.FromHours(value);

        /// <inheritdoc cref="TimeSpan.FromDays"/>
        public static TimeSpan Days(this int value) => TimeSpan.FromDays(value);

        /// <inheritdoc cref="TimeSpan.FromDays"/>
        public static TimeSpan Days(this long value) => TimeSpan.FromDays(value);

        /// <inheritdoc cref="TimeSpan.FromDays"/>
        public static TimeSpan Days(this double value) => TimeSpan.FromDays(value);

        /// <inheritdoc cref="TimeSpan.FromTicks"/>
        public static TimeSpan Ticks(this int value) => TimeSpan.FromTicks(value);

        /// <inheritdoc cref="TimeSpan.FromTicks"/>
        public static TimeSpan Ticks(this long value) => TimeSpan.FromTicks(value);
    }
}