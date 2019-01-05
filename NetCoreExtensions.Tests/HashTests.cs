using NetCoreExtensions.Security;
using Shouldly;
using System.Text;
using Xunit;

namespace NetCoreExtensions.Tests
{
    public class HashTests
    {
        private const string TestDataString = "This Contains 🎈Unicode👏";
        private static readonly byte[] TestDataBytes = new byte[] { 0, 1, 2 };
        private const string HmacKeyString = "Secret1";
        private static readonly byte[] HmacKeyBytes = new byte[] { 2, 0, 42 };

        [Fact]
        public void Sha1_ByteArray()
        {
            new byte[] { 0, 1, 2 }.Sha1()
                .ToString()
                .ShouldBe("0c7a623fd2bbc05b06423be359e4021d36e721ad");
        }

        [Fact]
        public void Sha1_String()
        {
            "test1".Sha1()
                .ToString()
                .ShouldBe("b444ac06613fc8d63795be9ad0beaf55011936ac");
        }

        [Fact]
        public void Sha1_String_ASCII()
        {
            "test2".Sha1(Encoding.ASCII)
                .ToString()
                .ShouldBe("109f4b3c50d7b0df729d299bc6f8e9ef9066971f");
        }

        [Fact]
        public void Sha256_ByteArray()
        {
            new byte[] { 0, 1, 2 }.Sha256()
                .ToString()
                .ShouldBe("ae4b3280e56e2faf83f414a6e3dabe9d5fbe18976544c05fed121accb85b53fc");
        }

        [Fact]
        public void Sha256_String()
        {
            "test1".Sha256()
                .ToString()
                .ShouldBe("1b4f0e9851971998e732078544c96b36c3d01cedf7caa332359d6f1d83567014");
        }

        [Fact]
        public void Sha256_String_ASCII()
        {
            "test2".Sha256(Encoding.ASCII)
                .ToString()
                .ShouldBe("60303ae22b998861bce3b28f33eec1be758a213c86c93c076dbe9f558c11c752");
        }

        [Fact]
        public void Sha384_ByteArray()
        {
            new byte[] { 0, 1, 2 }.Sha384()
                .ToString()
                .ShouldBe("4f895854c1a4fc5aa2e0456eaf8d0ecaa70c196bd901153861d76b8fa3cd95ceea29eab6a279f8b08437703ce0b4b91a");
        }

        [Fact]
        public void Sha384_String()
        {
            "test1".Sha384()
                .ToString()
                .ShouldBe("44accf4a6221d01de386da6d2c48b0fae47930c80d2371cd669bff5235c6c1a5ce47f863a1379829f8602822f96410c2");
        }

        [Fact]
        public void Sha384_String_ASCII()
        {
            "test2".Sha384(Encoding.ASCII)
                .ToString()
                .ShouldBe("96fd02f78758ae9d418feb871df005460fada2b6a0a83b731842fcf5ce717490413423a18e8806bfde10f132d153367b");
        }

        [Fact]
        public void Sha512_ByteArray()
        {
            new byte[] { 0, 1, 2 }.Sha512()
                .ToString()
                .ShouldBe("8081da5f9c1e3d0e1aa16f604d5e5064543cff5d7bace2bb312252461e151b3fe0f034ea8dc1dacff3361a892d625fbe1b614cda265f87a473c24b0fa1d91dfd");
        }

        [Fact]
        public void Sha512_String()
        {
            "test1".Sha512()
                .ToString()
               .ShouldBe("b16ed7d24b3ecbd4164dcdad374e08c0ab7518aa07f9d3683f34c2b3c67a15830268cb4a56c1ff6f54c8e54a795f5b87c08668b51f82d0093f7baee7d2981181");
        }

        [Fact]
        public void Sha512_String_ASCII()
        {
            "test2".Sha512(Encoding.ASCII)
                .ToString()
                .ShouldBe("6d201beeefb589b08ef0672dac82353d0cbd9ad99e1642c83a1601f3d647bcca003257b5e8f31bdc1d73fbec84fb085c79d6e2677b7ff927e823a54e789140d9");
        }

        [Fact]
        public void HmacSha1_ByteArray_KeyBytes()
        {
            TestDataBytes.HmacSha1(HmacKeyBytes)
                .ToString()
                .ShouldBe("5cd5cade3cc728222aef845d81fcf579a8ab1bc5");
        }

        [Fact]
        public void HmacSha1_ByteArray_KeyString()
        {
            TestDataBytes.HmacSha1(HmacKeyString)
                .ToString()
                .ShouldBe("605a55bc35e5bba2c5106c7a5a2481fc95587034");
        }

        [Fact]
        public void HmacSha1_String_KeyBytes()
        {
            TestDataString.HmacSha1(HmacKeyBytes)
                .ToString()
                .ShouldBe("8c340ab45a7e4b967e74b1636354b3ff94886107");
        }

        [Fact]
        public void HmacSha1_String_KeyBytes_ASCII()
        {
            TestDataString.HmacSha1(HmacKeyBytes, Encoding.ASCII)
                .ToString()
                .ShouldBe("a98021e81accd23ee7608d8e7e568c18333c803c");
        }

        [Fact]
        public void HmacSha1_String_KeyString()
        {
            TestDataString.HmacSha1(HmacKeyString)
                .ToString()
                .ShouldBe("08b6967b073ccf1e7310df381fc920556bf2cf07");
        }

        [Fact]
        public void HmacSha1_String_KeyString_ASCII()
        {
            TestDataString.HmacSha1(HmacKeyString, Encoding.ASCII)
                .ToString()
                .ShouldBe("e2ccedbd9619d43caf83b52cb7bd1d672a277c93");
        }

        [Fact]
        public void HmacSha256_ByteArray_KeyBytes()
        {
            TestDataBytes.HmacSha256(HmacKeyBytes)
                .ToString()
                .ShouldBe("11180388b5bdd6ee015ea331fbc28265c680500cdad234fbb471e0f39b30c9f2");
        }

        [Fact]
        public void HmacSha256_ByteArray_KeyString()
        {
            TestDataBytes.HmacSha256(HmacKeyString)
                .ToString()
                .ShouldBe("be196b5a71fea6d4880ec45f3ee1b7d7fdc370be004ddefc2d9f96810a81f9fc");
        }

        [Fact]
        public void HmacSha256_String_KeyBytes()
        {
            TestDataString.HmacSha256(HmacKeyBytes)
                .ToString()
                .ShouldBe("589d4449a0c0004949101244f6b3f297d58c0cd17889db949502d90c3760b777");
        }

        [Fact]
        public void HmacSha256_String_KeyBytes_ASCII()
        {
            TestDataString.HmacSha256(HmacKeyBytes, Encoding.ASCII)
                .ToString()
                .ShouldBe("d65f6fb44c9abbfc0ba4cfc09e3bd48e6abd93b26b4c8d4c08eab17784070aef");
        }

        [Fact]
        public void HmacSha256_String_KeyString()
        {
            TestDataString.HmacSha256(HmacKeyString)
                .ToString()
                .ShouldBe("4b71cf2ef0bb3c515c8e78a47a392f086195112cf92edafd18bf7dadf716890c");
        }

        [Fact]
        public void HmacSha256_String_KeyString_ASCII()
        {
            TestDataString.HmacSha256(HmacKeyString, Encoding.ASCII)
                .ToString()
                .ShouldBe("1e0a5d97944fa2e2cfc841e420537ed12b173120e3f514a948b6905e9e1f9754");
        }

        [Fact]
        public void HmacSha384_ByteArray_KeyBytes()
        {
            TestDataBytes.HmacSha384(HmacKeyBytes)
                .ToString()
                .ShouldBe("110a24642499589695f9f82554ce7488ffea4b740dd37d3928ad8f6f4f3d58518dd85aa7da7f492d74852181cfd3c39d");
        }

        [Fact]
        public void HmacSha384_ByteArray_KeyString()
        {
            TestDataBytes.HmacSha384(HmacKeyString)
                .ToString()
                .ShouldBe("e786a25ce0de3b6404148013440db00a804589abf66592043ec1d725610c7dfd570858fa29e8138cd2f18789ec4ee332");
        }

        [Fact]
        public void HmacSha384_String_KeyBytes()
        {
            TestDataString.HmacSha384(HmacKeyBytes)
                .ToString()
                .ShouldBe("320aa9cc808f5899ce43cd4f2c634634b462af96685e6fb80c642532c337ea9bac8efa41ea8a6b9200a8a1b221560772");
        }

        [Fact]
        public void HmacSha384_String_KeyBytes_ASCII()
        {
            TestDataString.HmacSha384(HmacKeyBytes, Encoding.ASCII)
                .ToString()
                .ShouldBe("abd23b0a684d154ceca8850feca38c40527b63849d1a94cd9674acbca2fadac084ce406d3a2a1822d180600f40b4426a");
        }

        [Fact]
        public void HmacSha384_String_KeyString()
        {
            TestDataString.HmacSha384(HmacKeyString)
                .ToString()
                .ShouldBe("e4d2466df9cf2061993dd4caa98853ce8e93d42430a1077fdc25b20111102baf6da7dd4aa003bfa55e0dfa5391ed04dd");
        }

        [Fact]
        public void HmacSha384_String_KeyString_ASCII()
        {
            TestDataString.HmacSha384(HmacKeyString, Encoding.ASCII)
                .ToString()
                .ShouldBe("6784c450fe82837355a561c8d617ef2a1d512b29f23926a8fac4fa55990aa77e8cb2e3f2555f86ef1377fd79ec6703af");
        }

        [Fact]
        public void HmacSha512_ByteArray_KeyBytes()
        {
            TestDataBytes.HmacSha512(HmacKeyBytes)
                .ToString()
                .ShouldBe("e111e55b37c97274b51805cd4cf1f83fafcfb0626a23d91052df4944d4b4ae5bd3fcc8a43e17f3ca0ecc97eb46c1333eaafc7738b2b83b7e7005599352d2d429");
        }

        [Fact]
        public void HmacSha512_ByteArray_KeyString()
        {
            TestDataBytes.HmacSha512(HmacKeyString)
                .ToString()
                .ShouldBe("7cb5be7ea977711db6dd882f1615efd21862d1be7821a2762c108e08998a2961d41fdf3067d53f987394fe1b8fcc20b29b4e27121aa9c06612abc33c8d21b7a6");
        }

        [Fact]
        public void HmacSha512_String_KeyBytes()
        {
            TestDataString.HmacSha512(HmacKeyBytes)
                .ToString()
                .ShouldBe("a47100f5e4f03e4a6c6b1d609926c10ae2596705414660fb32c7d2e7b1853168e581a0fdd95d2909eadb829f768321e6ce5dce57c69bee82776adcef7649cb62");
        }

        [Fact]
        public void HmacSha512_String_KeyBytes_ASCII()
        {
            TestDataString.HmacSha512(HmacKeyBytes, Encoding.ASCII)
                .ToString()
                .ShouldBe("4c2a1068e752119ed10afad6fe0883f13bfed804c358c9010b9350431270e52a1c901eadb87417b1ab47b65af93f5f49939549727713fd57f482b58f68fa34b9");
        }

        [Fact]
        public void HmacSha512_String_KeyString()
        {
            TestDataString.HmacSha512(HmacKeyString)
                .ToString()
                .ShouldBe("91848c80d4fd7f903503ab9c7a1c2f87f2c8c42761b1b712ec02a0be3c7269a1cfec80e6fe5de677eaee753ebaadcdb9d25d219da00479e4b36ab82fed45575c");
        }

        [Fact]
        public void HmacSha512_String_KeyString_ASCII()
        {
            TestDataString.HmacSha512(HmacKeyString, Encoding.ASCII)
                .ToString()
                .ShouldBe("59c2c08cde1dda17d8703814d3d6d994d317cb27beab18d7ada05fd36197bcbbc02d04767ad3f8a1cd24caefc1d81338ed3090ea582b6ea73032435e4f7ac21f");
        }
    }
}