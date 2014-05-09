using Codility.L4.Sorting;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L4.Sorting
{
    public class DistinctTests
    {
        [Fact]
        public void valid_array()
        {
            var A = new[] { 2, 1, 1, 2, 3, 1 };

            Distinct.solution(A).Should().Be(3);
        }
    }
}
