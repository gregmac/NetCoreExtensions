using NetCoreExtensions.DateTime;
using Xunit;

namespace NetCoreExtensions.Tests
{
    public class DateTimeTests
    {
        [Fact]
        public void TimeSpanConversions_Int()
        {
            Assert.Equal(42, 42.Milliseconds().TotalMilliseconds);
            Assert.Equal(43, 43.Seconds().TotalSeconds);
            Assert.Equal(44, 44.Minutes().TotalMinutes);
            Assert.Equal(45, 45.Hours().TotalHours);
            Assert.Equal(46, 46.Days().TotalDays);
            Assert.Equal(47, 47.Ticks().Ticks);
        }
        
        [Fact]
        public void TimeSpanConversions_Double()
        {
            Assert.Equal(42D, 42D.Milliseconds().TotalMilliseconds); // Note milliseconds rounds down
            Assert.Equal(43D, 43D.Seconds().TotalSeconds);
            Assert.Equal(44D, 44D.Minutes().TotalMinutes);
            Assert.Equal(45D, 45D.Hours().TotalHours);
            Assert.Equal(46D, 46D.Days().TotalDays);
            // Note: Ticks doesn't support double
        }
        
        
        [Fact]
        public void TimeSpanConversions_Long()
        {
            Assert.Equal(2147483650L, 2147483650L.Milliseconds().TotalMilliseconds);
            Assert.Equal(2147483651L, 2147483651L.Seconds().TotalSeconds);
            Assert.Equal(2147483652L, 2147483652L.Minutes().TotalMinutes);
            Assert.Equal(42L, 42L.Hours().TotalHours);
            Assert.Equal(43L, 43L.Days().TotalDays);
            Assert.Equal(2147483655L, 2147483655L.Ticks().Ticks);
        }
        
    }
}