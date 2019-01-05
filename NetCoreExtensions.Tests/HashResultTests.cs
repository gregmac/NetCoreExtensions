using NetCoreExtensions.Security;
using Shouldly;
using Xunit;

namespace NetCoreExtensions.Tests
{
    public class HashResultTests
    {
        private static byte[] TestData = new byte[] { 0, 31, 242, 171, 205, 239, 0 };

        [Fact]
        public void HashResult_ToString()
        {
            new HashResult(TestData).ToString()
                .ShouldBe("001ff2abcdef00");
        }
        [Fact]
        public void HashResult_ToString_Lowercase()
        {
            new HashResult(TestData).ToString(HashResultFormatting.Lowercase)
                .ShouldBe("001ff2abcdef00");
        }

        [Fact]
        public void HashResult_ToString_Uppercase()
        {
            new HashResult(TestData).ToString(HashResultFormatting.Uppercase)
                .ShouldBe("001FF2ABCDEF00");
        }

        [Fact]
        public void HashResult_ToString_Base64()
        {
            new HashResult(TestData).ToString(HashResultFormatting.Base64)
                .ShouldBe("AB/yq83vAA==");
        }

        [Fact]
        public void HashResult_Implicit_String()
        {
            string output = new HashResult(TestData);
            output.ShouldBe("001ff2abcdef00");
        }
    }
}