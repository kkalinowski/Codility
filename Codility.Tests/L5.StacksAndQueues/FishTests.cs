using Codility.L5.StacksAndQueues;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L5.StacksAndQueues
{
    public class FishTests
    {
        [Fact]
        public void example()
        {
            var A = new[] { 4, 3, 2, 1, 5 };
            var B = new[] { 0, 1, 0, 0, 0 };

            Fish.solution(A, B).Should().Be(2);
        }
    }
}
