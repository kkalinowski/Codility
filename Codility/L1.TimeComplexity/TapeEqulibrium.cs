using System;
using System.Linq;

namespace Codility.L1.TimeComplexity
{
    public static class TapeEqulibrium
    {
        public static int solution(int[] A)
        {
            var subSums = new int[A.Length];
            subSums[0] = A[0];
            for (var i = 1; i < A.Length; i++)
                subSums[i] = subSums[i - 1] + A[i];

            var bestDiff = int.MaxValue;
            var totalSum = subSums.Last();

            for (var i = 0; i < subSums.Length - 1; i++)
            {
                var diff = Math.Abs(2 * subSums[i] - totalSum);
                if (diff <= bestDiff)
                    bestDiff = diff;
            }

            return bestDiff;
        }
    }
}
