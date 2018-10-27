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

        [Fact]
        public void Join()
        {
            Assert.Equal("42,43,44", new[] {42, 43, 44}.Join(","));
            Assert.Equal("a**b**c", new[] {"a", "b", "c"}.Join("**"));
        }

        [Fact]
        public void DefaultIfNullOrEmpty_string()
        {
            Assert.Equal("abc", "abc".DefaultIfNullOrEmpty("default"));
            Assert.Equal(" ", " ".DefaultIfNullOrEmpty("default"));
            Assert.Equal("default", "".DefaultIfNullOrEmpty("default"));
            Assert.Equal("default", ((string)null).DefaultIfNullOrEmpty("default"));
        }
        
        [Fact]
        public void DefaultIfNullOrEmpty_callback()
        {
            var i = 0;
            Assert.Equal("abc", "abc".DefaultIfNullOrEmpty(() => (i++).ToString()));
            Assert.Equal(" ", " ".DefaultIfNullOrEmpty(() => (i++).ToString()));
            Assert.Equal("0", "".DefaultIfNullOrEmpty(() => (i++).ToString()));
            Assert.Equal("1", ((string)null).DefaultIfNullOrEmpty(() => (i++).ToString()));
            Assert.Equal(2, i);
        }
        
        [Fact]
        public void DefaultIfNullOrWhitespace_string()
        {
            Assert.Equal("abc", "abc".DefaultIfNullOrWhitespace("default"));
            Assert.Equal("default", " ".DefaultIfNullOrWhitespace("default"));
            Assert.Equal("default", "".DefaultIfNullOrWhitespace("default"));
            Assert.Equal("default", ((string)null).DefaultIfNullOrWhitespace("default"));
        }
        [Fact]
        public void DefaultIfNullOrWhitespace_callback()
        {
            var i = 0;
            Assert.Equal("abc", "abc".DefaultIfNullOrWhitespace(() => (i++).ToString()));
            Assert.Equal("0", " ".DefaultIfNullOrWhitespace(() => (i++).ToString()));
            Assert.Equal("1", "".DefaultIfNullOrWhitespace(() => (i++).ToString()));
            Assert.Equal("2", ((string)null).DefaultIfNullOrWhitespace(() => (i++).ToString()));
            Assert.Equal(3, i);
        }
    }
}