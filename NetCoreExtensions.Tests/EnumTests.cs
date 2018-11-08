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


        [Theory]
        [InlineData(0, TestEnum.Value0)]
        [InlineData(42, TestEnum.Value42)]
        [InlineData(99, null)]
        public void ToEnum_Int_Nullable(int input, TestEnum? expected)
        {
            input.ToEnum<TestEnum>().ShouldBe(expected);
        }

        [Theory]
        [InlineData(0, TestEnum.Value42, TestEnum.Value0)]
        [InlineData(42, TestEnum.Value42, TestEnum.Value42)]
        [InlineData(99, TestEnum.Value42, TestEnum.Value42)]
        public void ToEnum_Int_Default(int input, TestEnum defaultValue, TestEnum expected)
        {
            input.ToEnum(defaultValue).ShouldBe(expected);
        }


        [Theory]
        [InlineData("Value0", TestEnum.Value0)]
        [InlineData("value0", null)]
        [InlineData("Value1", TestEnum.Value1)]
        [InlineData("1", TestEnum.Value1)]
        [InlineData("42", TestEnum.Value42)]
        [InlineData("99", null)]
        [InlineData(null, null)]
        [InlineData("", null)]
        public void ToEnum_String_Nullable(string input, TestEnum? expected)
        {
            input.ToEnum<TestEnum>().ShouldBe(expected);
        }

        [Theory]
        [InlineData("value0", TestEnum.Value0)]
        public void ToEnum_String_Nullable_IgnoreCase(string input, TestEnum? expected)
        {
            input.ToEnum<TestEnum>(ignoreCase: true).ShouldBe(expected);
        }


        [Theory]
        [InlineData("Value0", TestEnum.Value42, TestEnum.Value0)]
        [InlineData("Value5", TestEnum.Value42, TestEnum.Value42)]
        [InlineData(null, TestEnum.Value42, TestEnum.Value42)]
        [InlineData("", TestEnum.Value42, TestEnum.Value42)]
        [InlineData("99", TestEnum.Value42, TestEnum.Value42)]
        public void ToEnum_String_Default(string input, TestEnum defaultValue, TestEnum expected)
        {
            input.ToEnum(defaultValue).ShouldBe(expected);
        }

        [Theory]
        [InlineData("Value0", TestEnum.Value42, TestEnum.Value0)]
        [InlineData("Value5", TestEnum.Value42, TestEnum.Value42)]
        [InlineData(null, TestEnum.Value42, TestEnum.Value42)]
        [InlineData("", TestEnum.Value42, TestEnum.Value42)]
        public void ToEnum_String_Default_IgnoreCase(string input, TestEnum defaultValue, TestEnum expected)
        {
            input.ToEnum(ignoreCase: true, defaultValue).ShouldBe(expected);
        }

    }
}
