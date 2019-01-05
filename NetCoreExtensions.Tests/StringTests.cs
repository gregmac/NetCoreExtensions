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
        [InlineData("abc", false)]
        [InlineData("   ", false)]
        [InlineData(" ", false)]
        [InlineData("", true)]
        [InlineData(null, true)]
        public void EmptyToNull(string input, bool expectedNull)
        {
            input.EmptyToNull()
                .ShouldBe(expectedNull ? null : input);
        }

        [Theory]
        [InlineData("abc", false)]
        [InlineData("   ", true)]
        [InlineData(" ", true)]
        [InlineData("", true)]
        [InlineData(null, true)]
        public void WhiteSpaceToNull(string input, bool expectedNull)
        {
            input.WhiteSpaceToNull()
                .ShouldBe(expectedNull ? null : input);
        }
    }
}