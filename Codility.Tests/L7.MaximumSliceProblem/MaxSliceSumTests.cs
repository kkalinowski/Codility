using Codility.L7.MaximumSliceProblem;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L7.MaximumSliceProblem
{
    public class MaxSliceSumTests
    {
        [Fact]
        public void example()
        {
            var A = new[] { 3, 2, -6, 4, 0 };

            MaxSliceSum.solution(A).Should().Be(5);
        }

        [Fact]
        public void one_element()
        {
            var A = new[] { -10 };

            MaxSliceSum.solution(A).Should().Be(-10);
        }
    }
}
