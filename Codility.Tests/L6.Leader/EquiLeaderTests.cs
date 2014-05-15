using Codility.L6.Leader;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L6.Leader
{
    public class EquiLeaderTests
    {
        [Fact]
        public void example()
        {
            var A = new[] { 4, 3, 4, 4, 4, 2 };

            EquiLeader.solution(A).Should().Be(2);
        }
    }
}
