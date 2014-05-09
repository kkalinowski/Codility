using Codility.L1.TimeComplexity;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L1.TimeComplexity
{
    public class TapeEqulibriumTests
    {
        [Fact]
        public void two_elements_array()
        {
            var A = new[] {1, 2000};

            TapeEqulibrium.solution(A).Should().Be(1999);
        }

        [Fact]
        public void two_elements_array_2()
        {
            var A = new[] { 1000, -1000 };

            TapeEqulibrium.solution(A).Should().Be(2000);
        }
    }
}
