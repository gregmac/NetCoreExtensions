using NetCoreExtensions.Regex;
using Shouldly;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace NetCoreExtensions.Tests
{
    public class RegexTests
    {
        [Fact]
        public void Match()
        {
            "test".Match("^t").Value.ShouldBe("t");
        }

        [Fact]
        public void Match_Options()
        {
            "test".Match("^T", RegexOptions.IgnoreCase).Value.ShouldBe("t");
        }
        
        [Fact]
        public void TryMatch()
        {
            "test".TryMatch("^t", out var match).ShouldBeTrue();
            match.Value.ShouldBe("t");
        }
        
        [Fact]
        public void TryMatch_Options()
        {
            "test".TryMatch("^T", RegexOptions.IgnoreCase, out var match).ShouldBeTrue();
            match.Value.ShouldBe("t");
        }
        
        [Fact]
        public void Matches()
        {
            var matches = "a1a2b3a4a5A6".Matches("a[0-9]");
            matches.ShouldAllBe(x => x.Value.StartsWith("a"));
            matches.Count().ShouldBe(4);
        }
        
        
        [Fact]
        public void Matches_Options()
        {
            var matches = "a1a2b3a4a5A6".Matches("A[0-9]", RegexOptions.IgnoreCase);
            matches.ShouldAllBe(x => x.Value.StartsWith("a") || x.Value.StartsWith("A"));
            matches.Count().ShouldBe(5);
        }
    }
}