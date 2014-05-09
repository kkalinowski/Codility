using System;

namespace Codility.L4.Sorting
{
    public static class NumberOfDiscIntersections
    {
        public static int solution(int[] A)
        {
            var N = A.Length;
            var discStartPoints = new int[N];
            var discEndPoints = new int[N];

            for (long i = 0; i < N; i++)
            {
                discStartPoints[Math.Max(0, i - A[i])]++;
                discEndPoints[Math.Min(N - 1, i + A[i])]++;
            }

            var startedDiscs = 0;
            var result = 0;
            for (int i = 0; i < N; i++)
            {
                if (discStartPoints[i] > 0)
                {
                    result += startedDiscs * discStartPoints[i];
                    result += discStartPoints[i] * (discStartPoints[i] - 1) / 2;
                    startedDiscs += discStartPoints[i];
                }

                startedDiscs -= discEndPoints[i];
            }

            return result <= 10000000 ? result : -1;
        }
    }
}