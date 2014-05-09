using Codility.L1.TimeComplexity;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L1.TimeComplexity
{
    public class PermMissingElemTests
    {
        [Fact]
        public void example()
        {
            var A = new[] {2, 3, 1, 5};

            PermMissingElem.solution(A).Should().Be(4);
        }

    }
}
