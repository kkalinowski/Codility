using Codility.L7.MaximumSliceProblem;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L7.MaximumSliceProblem
{
    public class MaxDoubleSliceSumTests
    {
        [Fact]
        public void example()
        {
            var A = new[] { 3, 2, 6, -1, 4, 5, -1, 2 };

            MaxDoubleSliceSum.solution(A).Should().Be(17);
        }
    }
}
