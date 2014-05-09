using Codility.L4.Sorting;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L4.Sorting
{
    public class TriangleTests
    {
        [Fact]
        public void valid_array()
        {
            var A = new[] { 10, 2, 5, 1, 8, 20 };

            Triangle.solution(A).Should().Be(1);
        }

        [Fact]
        public void invalid_array()
        {
            var A = new[] { 10, 50, 5, 1 };

            Triangle.solution(A).Should().Be(0);
        }
    }
}
