using Codility.L7.MaximumSliceProblem;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L7.MaximumSliceProblem
{
    public class MaxProfitTests
    {
        [Fact]
        public void example()
        {
            var A = new[] { 23171, 21011, 21123, 21366, 21013, 21367 };

            MaxProfit.solution(A).Should().Be(356);
        }
    }
}
