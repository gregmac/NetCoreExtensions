using NetCoreExtensions.DateTime;
using Xunit;

namespace NetCoreExtensions.Tests
{
    public class DateTimeTests
    {
        [Fact]
        public void TimeSpanConversions()
        {
            Assert.Equal(42, 42.Milliseconds().TotalMilliseconds);
            Assert.Equal(43, 43.Seconds().TotalSeconds);
            Assert.Equal(44, 44.Minutes().TotalMinutes);
            Assert.Equal(45, 45.Hours().TotalHours);
            Assert.Equal(46, 46.Days().TotalDays);
            Assert.Equal(47, 47.Ticks().Ticks);
        }
    }
}