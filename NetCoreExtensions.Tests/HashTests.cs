using System.Text;
using NetCoreExtensions.Security;
using Xunit;

namespace NetCoreExtensions.Tests
{
    public class HashTests
    {
        [Fact]
        public void Sha1_ByteArray()
        {
            Assert.Equal("0c7a623fd2bbc05b06423be359e4021d36e721ad", new byte[] { 0, 1, 2 }.Sha1());
        }

        [Fact]
        public void Sha1_String()
        {
            Assert.Equal("b444ac06613fc8d63795be9ad0beaf55011936ac", "test1".Sha1());
        }

        [Fact]
        public void Sha1_String_ASCII()
        {
            Assert.Equal("109f4b3c50d7b0df729d299bc6f8e9ef9066971f", "test2".Sha1(Encoding.ASCII));
        }

        [Fact]
        public void Sha256_ByteArray()
        {
            Assert.Equal("ae4b3280e56e2faf83f414a6e3dabe9d5fbe18976544c05fed121accb85b53fc", new byte[] { 0, 1, 2 }.Sha256());
        }

        [Fact]
        public void Sha256_String()
        {
            Assert.Equal("1b4f0e9851971998e732078544c96b36c3d01cedf7caa332359d6f1d83567014", "test1".Sha256());
        }
        
        [Fact]
        public void Sha256_String_ASCII()
        {
            Assert.Equal("60303ae22b998861bce3b28f33eec1be758a213c86c93c076dbe9f558c11c752", "test2".Sha256(Encoding.ASCII));
        }
        
        [Fact]
        public void Sha384_ByteArray()
        {
            Assert.Equal("4f895854c1a4fc5aa2e0456eaf8d0ecaa70c196bd901153861d76b8fa3cd95ceea29eab6a279f8b08437703ce0b4b91a", new byte[] { 0, 1, 2 }.Sha384());
        }

        [Fact]
        public void Sha384_String()
        {
            Assert.Equal("44accf4a6221d01de386da6d2c48b0fae47930c80d2371cd669bff5235c6c1a5ce47f863a1379829f8602822f96410c2", "test1".Sha384());
        }
        
        [Fact]
        public void Sha384_String_ASCII()
        {
            Assert.Equal("96fd02f78758ae9d418feb871df005460fada2b6a0a83b731842fcf5ce717490413423a18e8806bfde10f132d153367b", "test2".Sha384(Encoding.ASCII));
        }
        
        [Fact]
        public void Sha512_ByteArray()
        {
            Assert.Equal("8081da5f9c1e3d0e1aa16f604d5e5064543cff5d7bace2bb312252461e151b3fe0f034ea8dc1dacff3361a892d625fbe1b614cda265f87a473c24b0fa1d91dfd", new byte[] { 0, 1, 2 }.Sha512());
        }

        [Fact]
        public void Sha512_String()
        {
            Assert.Equal("b16ed7d24b3ecbd4164dcdad374e08c0ab7518aa07f9d3683f34c2b3c67a15830268cb4a56c1ff6f54c8e54a795f5b87c08668b51f82d0093f7baee7d2981181", "test1".Sha512());
        }
        
        [Fact]
        public void Sha512_String_ASCII()
        {
            Assert.Equal("6d201beeefb589b08ef0672dac82353d0cbd9ad99e1642c83a1601f3d647bcca003257b5e8f31bdc1d73fbec84fb085c79d6e2677b7ff927e823a54e789140d9", "test2".Sha512(Encoding.ASCII));
        }
    }
}