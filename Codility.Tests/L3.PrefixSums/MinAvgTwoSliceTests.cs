using Codility.L3.PrefixSums;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L3.PrefixSums
{
    public class MinAvgTwoSliceTests
    {
        [Fact]
        public void valid_array()
        {
            var A = new[] {4, 2, 2, 5, 1, 5, 8};

            MinAvgTwoSlice.solution(A).Should().Be(1);
        }
    }
}
