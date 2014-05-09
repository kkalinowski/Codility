using Codility.L3.PrefixSums;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L3.PrefixSums
{
    public class PassingCarsTests
    {
        [Fact]
        public void valid_array()
        {
            var A = new[] { 0, 1, 0, 1, 1 };

            PassingCars.solution(A).Should().Be(5);
        }
    }
}
