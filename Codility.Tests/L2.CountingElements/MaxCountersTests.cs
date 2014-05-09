using Codility.L2.CountingElements;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L2.CountingElements
{
    public class MaxCountersTests
    {
        [Fact]
        public void valid_array()
        {
            var A = new[] { 3, 4, 4, 6, 1, 4, 4 };

            var expected = new[] {3, 2, 2, 4, 2};
            MaxCounters.solution(5, A).Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void valid_array_2()
        {
            var A = new[] { 1, 2 };

            var expected = new[] { 1, 1 };
            MaxCounters.solution(2, A).Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void valid_array_3()
        {
            var A = new[] { 1, 3, 2 };

            var expected = new[] { 1, 2 };
            MaxCounters.solution(2, A).Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void only_max_operations()
        {
            var A = new[] { 3, 3, 3 };

            var expected = new[] { 0, 0 };
            MaxCounters.solution(2, A).Should().BeEquivalentTo(expected);
        }
    }
}
