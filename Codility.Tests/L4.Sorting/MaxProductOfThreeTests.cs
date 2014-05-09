using Codility.L4.Sorting;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L4.Sorting
{
    public class MaxProductOfThreeTests
    {
        [Fact]
        public void valid_array()
        {
            var A = new[] { -3, 1, 2, -2, 5, 6 };

            MaxProductOfThree.solution(A).Should().Be(60);
        }
    }
}
