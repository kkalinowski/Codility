using Codility.L2.CountingElements;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L2.CountingElements
{
    public class PermCheckTests
    {
        [Fact]
        public void valid_array()
        {
            var A = new[] { 4, 1, 3, 2 };

            PermCheck.solution(A).Should().Be(1);
        }

        [Fact]
        public void invalid_array()
        {
            var A = new[] { 4, 1, 3 };

            PermCheck.solution(A).Should().Be(0);
        }
    }
}
