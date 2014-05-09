using Codility.L2.CountingElements;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L2.CountingElements
{
    public class FrogRiverOneTests
    {
        [Fact]
        public void example()
        {
            var A = new[] { 1, 3, 1, 4, 2, 3, 5, 4 };

            FrogRiverOne.solution(5, A).Should().Be(6);
        }

        [Fact]
        public void one_element_array()
        {
            var A = new[] { 1 };

            FrogRiverOne.solution(1, A).Should().Be(0);
        }

        [Fact]
        public void invalid_array()
        {
            var A = new[] { 1, 3, 5 };

            FrogRiverOne.solution(2, A).Should().Be(-1);
        }

        [Fact]
        public void invalid_array_2()
        {
            var A = new[] { 1, 5, 5 };

            FrogRiverOne.solution(2, A).Should().Be(-1);
        }
    }
}
