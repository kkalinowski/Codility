using Codility.L5.StacksAndQueues;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L5.StacksAndQueues
{
    public class NestingTests
    {
        [Fact]
        public void valid()
        {
            var S = "(()(())())";

            Nesting.solution(S).Should().Be(1);
        }

        [Fact]
        public void invalid()
        {
            var S = "())";

            Nesting.solution(S).Should().Be(0);
        }
    }
}
