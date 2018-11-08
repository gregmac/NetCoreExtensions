using NetCoreExtensions.Strings;
using Shouldly;
using Xunit;

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
            testValue.IsNullOrEmpty().ShouldBe(expected);
            testValue.IsNotNullOrEmpty().ShouldNotBe(expected);
        }
        
        
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData("       ", true)]
        [InlineData("NotEmpty", false)]
        public void IsNullOrWhiteSpace(string testValue, bool expected)
        {
            testValue.IsNullOrWhiteSpace().ShouldBe(expected);
            testValue.IsNotNullOrWhiteSpace().ShouldNotBe(expected);
        }

        [Theory]
        [InlineData(new object[] { 42, 43, 44 }, ",", "42,43,44")]
        [InlineData(new object[] { "a", "b", "c" }, "**", "a**b**c")]
        public void Join(object[] input, string separator, string expected)
        {
            input.Join(separator).ShouldBe(expected);
        }

        [Theory]
        [InlineData("abc", "default", false)]
        [InlineData(" ", "default", false)]
        [InlineData("", "default", true)]
        [InlineData(null, "default", true)]
        public void DefaultIfNullOrEmpty_string(string input, string defaultValue, bool expectedDefault)
        {
            input.DefaultIfNullOrEmpty(defaultValue)
                .ShouldBe(expectedDefault ? defaultValue : input);
        }
        
        [Theory]
        [InlineData("abc", "default", false)]
        [InlineData(" ", "default", false)]
        [InlineData("", "default", true)]
        [InlineData(null, "default", true)]
        public void DefaultIfNullOrEmpty_callback(string input, string defaultValue, bool expectedDefault)
        {
            var callbackCalled = false;
            input
                .DefaultIfNullOrEmpty(() =>
                {
                    callbackCalled = true;
                    return defaultValue;
                })
                .ShouldBe(expectedDefault ? defaultValue : input);
            // if default is expected, callback should have been invoked
            callbackCalled.ShouldBe(expectedDefault);
        }


        [Theory]
        [InlineData("abc", "default", false)]
        [InlineData(" ", "default", true)]
        [InlineData("", "default", true)]
        [InlineData(null, "default", true)]
        public void DefaultIfNullOrWhitespace_string(string input, string defaultValue, bool expectedDefault)
        {
            input.DefaultIfNullOrWhitespace(defaultValue)
                .ShouldBe(expectedDefault ? defaultValue : input);
        }

        [Theory]
        [InlineData("abc", "default", false)]
        [InlineData(" ", "default", true)]
        [InlineData("", "default", true)]
        [InlineData(null, "default", true)]
        public void DefaultIfNullOrWhitespace_callback(string input, string defaultValue, bool expectedDefault)
        {
            var callbackCalled = false;
            input
                .DefaultIfNullOrWhitespace(() =>
                {
                    callbackCalled = true;
                    return defaultValue;
                })
                .ShouldBe(expectedDefault ? defaultValue : input);
            // if default is expected, callback should have been invoked
            callbackCalled.ShouldBe(expectedDefault);
        }

    }
}