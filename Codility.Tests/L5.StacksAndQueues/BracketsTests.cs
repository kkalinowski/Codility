using Codility.L5.StacksAndQueues;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L5.StacksAndQueues
{
    public class BracketsTests
    {
        [Fact]
        public void valid()
        {
            var S = "{[()()]}";

            Brackets.solution(S).Should().Be(1);
        }

        [Fact]
        public void invalid()
        {
            var S = "([)()]";

            Brackets.solution(S).Should().Be(0);
        }

        [Fact]
        public void invalid2()
        {
            var S = "((())()";

            Brackets.solution(S).Should().Be(0);
        }
    }
}
