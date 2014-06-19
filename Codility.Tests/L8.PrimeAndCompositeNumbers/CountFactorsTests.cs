using Codility.L8.PrimeAndCompositeNumbers;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L8.PrimeAndCompositeNumbers
{
    public class CountFactorsTests
    {
        [Fact]
        public void example()
        {
            CountFactors.solution(24).Should().Be(8);
        }
    }
}
