using Codility.L3.PrefixSums;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L3.PrefixSums
{
    public class GenomicRangeQueryTests
    {
        [Fact]
        public void valid_array()
        {
            var S = "CAGCCTA";
            var P = new[] { 2, 5, 0 };
            var Q = new[] { 4, 5, 6 };

            var expected = new[] { 2, 4, 1 };
            GenomicRangeQuery.solution(S, P, Q).Should().BeEquivalentTo(expected);
        }
    }
}
