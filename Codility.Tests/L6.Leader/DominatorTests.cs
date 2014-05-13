using Codility.L6.Leader;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L6.Leader
{
    public class DominatorTests
    {
        [Fact]
        public void example()
        {
            var A = new[] { 3, 4, 3, 2, 3, -1, 3, 3 };

            Dominator.solution(A).Should().BeOneOf(new[] {0, 2, 4, 6, 7});
        }
    }
}
