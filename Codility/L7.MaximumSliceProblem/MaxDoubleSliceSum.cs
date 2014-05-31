using System;

namespace Codility.L7.MaximumSliceProblem
{
    public static class MaxDoubleSliceSum
    {
        public static int solution(int[] A)
        {
            var N = A.Length;
            var K1 = new int[N];
            var K2 = new int[N];

            for (int i = 1; i < N - 1; i++)
                K1[i] = Math.Max(K1[i - 1] + A[i], 0);

            for (int i = N - 2; i > 0; i--)
                K2[i] = Math.Max(K2[i + 1] + A[i], 0);

            var max = 0;
            for (int i = 1; i < N - 1; i++)
                max = Math.Max(max, K1[i - 1] + K2[i + 1]);

            return max;
        }
    }
}