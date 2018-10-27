using System.Text.RegularExpressions;
using NetCoreExtensions.Regex;
using Xunit;

namespace NetCoreExtensions.Tests
{
    public class RegexTests
    {
        [Fact]
        public void Match()
        {
            Assert.Equal("t", "test".Match("^t").Value);
        }

        [Fact]
        public void Match_Options()
        {
            Assert.Equal("t", "test".Match("^T", RegexOptions.IgnoreCase).Value);
        }
        
        [Fact]
        public void TryMatch()
        {
            if ("test".TryMatch("^t", out var match))
            {
                Assert.Equal("t", match.Value);
            }
            else
            {
                Assert.True(false, "TryMatch failed");
            }
        }
        
        [Fact]
        public void TryMatch_Options()
        {
            if ("test".TryMatch("^T", RegexOptions.IgnoreCase, out var match))
            {
                Assert.Equal("t", match.Value);
            }
            else
            {
                Assert.True(false, "TryMatch failed");
            }
        }
        
        [Fact]
        public void Matches()
        {
            var numMatches = 0;
            foreach (var match in "a1a2b3a4a5".Matches("a[0-9]"))
            {
                Assert.StartsWith("a", match.Value);
                numMatches += 1;
            }
            Assert.Equal(4, numMatches);
        }
        
        
        [Fact]
        public void Matches_Options()
        {
            var numMatches = 0;
            foreach (var match in "a1a2b3a4a5".Matches("A[0-9]", RegexOptions.IgnoreCase))
            {
                Assert.StartsWith("a", match.Value);
                numMatches += 1;
            }
            Assert.Equal(4, numMatches);
        }
    }
}