using Codility.L3.PrefixSums;
using FluentAssertions;
using Xunit;

namespace Codility.Tests.L3.PrefixSums
{
    public class CountDivTests
    {
        [Fact]
        public void test1()
        {
            CountDiv.solution(6, 11, 2).Should().Be(3);
        }

        [Fact]
        public void test2()
        {
            CountDiv.solution(11, 345, 17).Should().Be(20);
        }

        [Fact]
        public void test3()
        {
            CountDiv.solution(10, 10, 5).Should().Be(1);
        }

        [Fact]
        public void test4()
        {
            CountDiv.solution(11, 11, 5).Should().Be(0);
        }

        [Fact]
        public void test5()
        {
            CountDiv.solution(0, 1, 11).Should().Be(1);
        }

        [Fact]
        public void test6()
        {
            CountDiv.solution(2, 4, 2).Should().Be(2);
        }
    }
}
