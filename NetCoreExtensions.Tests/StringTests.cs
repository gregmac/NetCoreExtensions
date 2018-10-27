using Xunit;
using NetCoreExtensions.Strings;

namespace NetCoreExtensions.Tests
{
    public class StringTests
    {
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("NotEmpty", false)]
        public void IsNullOrEmpty(string testValue, bool expected)
        {
            Assert.Equal(testValue.IsNullOrEmpty(), expected);
            Assert.Equal(testValue.IsNotNullOrEmpty(), !expected);
        }
        
        
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData("       ", true)]
        [InlineData("NotEmpty", false)]
        public void IsNullOrWhiteSpace(string testValue, bool expected)
        {
            Assert.Equal(testValue.IsNullOrWhiteSpace(), expected);
            Assert.Equal(testValue.IsNotNullOrWhiteSpace(), !expected);
        }
        
    }
}