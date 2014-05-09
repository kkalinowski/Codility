using System;
using System.Linq;

namespace Codility.L4.Sorting
{
    public static class MaxProductOfThree
    {
        public static int solution(int[] A)
        {
            var N = A.Length;
            var sorted = A.OrderBy(x => x).ToArray();
            var last3 = sorted[N - 3] * sorted[N - 2] * sorted[N - 1];
            var first2last1 = sorted[0] * sorted[1] * sorted[N - 1];

            return Math.Max(last3, first2last1);
        }
    }
}