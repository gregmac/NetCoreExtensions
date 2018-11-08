using NetCoreExtensions.Enum;
using Shouldly;
using Xunit;

namespace NetCoreExtensions.Tests
{
    public class EnumTests
    {

        public enum TestEnum
        {
            Value0 = 0,
            Value1 = 1,
            Value42 = 42,
        }

        [Theory]
        [InlineData(TestEnum.Value0, "Value0")]
        [InlineData(TestEnum.Value42, "Value42")]
        public void GetName(TestEnum testValue, string expected)
        {
            testValue.GetName().ShouldBe(expected);
        }

    }
}
