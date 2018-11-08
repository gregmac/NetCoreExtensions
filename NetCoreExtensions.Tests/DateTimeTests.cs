using NetCoreExtensions.DateTime;
using Shouldly;
using Xunit;

namespace NetCoreExtensions.Tests
{
    public class DateTimeTests
    {
        [Fact]
        public void TimeSpanConversions_Int()
        {
            42.Milliseconds().TotalMilliseconds.ShouldBe(42);
            43.Seconds().TotalSeconds.ShouldBe(43);
            44.Minutes().TotalMinutes.ShouldBe(44);
            45.Hours().TotalHours.ShouldBe(45);
            46.Days().TotalDays.ShouldBe(46);
            47.Ticks().Ticks.ShouldBe(47);
        }
        
        [Fact]
        public void TimeSpanConversions_Double()
        {
            42D.Milliseconds().TotalMilliseconds.ShouldBe(42D); // Note milliseconds rounds down
            43D.Seconds().TotalSeconds.ShouldBe(43D);
            44D.Minutes().TotalMinutes.ShouldBe(44D);
            45D.Hours().TotalHours.ShouldBe(45D);
            46D.Days().TotalDays.ShouldBe(46D);
            // Note: Ticks doesn't support double
        }
        
        
        [Fact]
        public void TimeSpanConversions_Long()
        {
            2147483650L.Milliseconds().TotalMilliseconds.ShouldBe(2147483650L);
            2147483651L.Seconds().TotalSeconds.ShouldBe(2147483651L);
            2147483652L.Minutes().TotalMinutes.ShouldBe(2147483652L);
            42L.Hours().TotalHours.ShouldBe(42L);
            43L.Days().TotalDays.ShouldBe(43L);
            2147483655L.Ticks().Ticks.ShouldBe(2147483655L);
        }
        
    }
}