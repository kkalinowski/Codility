using Codility.L8.PrimeAndCompositeNumbers;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L8.PrimeAndCompositeNumbers
{
    public class MinPerimeterRectangleTests
    {
        [Fact]
        public void example()
        {
            MinPerimeterRectangle.solution(30).Should().Be(22);
        }
    }
}
