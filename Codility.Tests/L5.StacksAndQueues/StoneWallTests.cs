using Codility.L5.StacksAndQueues;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L5.StacksAndQueues
{
    public class StoneWallTests
    {
        [Fact]
        public void example()
        {
            var H = new[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 };

            StoneWall.solution(H).Should().Be(7);
        }
    }
}
