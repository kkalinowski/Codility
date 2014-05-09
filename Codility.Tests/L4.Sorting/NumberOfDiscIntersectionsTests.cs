using Codility.L4.Sorting;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L4.Sorting
{
    public class NumberOfDiscIntersectionsTests
    {
        [Fact]
        public void sample()
        {
            var A = new[] { 1, 5, 2, 1, 4, 0 };

            NumberOfDiscIntersections.solution(A).Should().Be(11);
        }
    }
}
