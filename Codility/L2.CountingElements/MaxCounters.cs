using System;
using System.Collections;

namespace Codility.L2.CountingElements
{
    public static class MaxCounters
    {
        public static int[] solution(int N, int[] A)
        {
            var countArray = new int[N];
            var max = 0;
            var maxToSet = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < N + 1)
                {
                    if (countArray[A[i] - 1] < maxToSet)
                        countArray[A[i] - 1] = maxToSet + 1;
                    else
                        countArray[A[i] - 1]++;

                    if (countArray[A[i] - 1] > max)
                        max = countArray[A[i] - 1];
                }
                else
                    maxToSet = max;
            }

            for (int i = 0; i < N; i++)
                countArray[i] = Math.Max(maxToSet, countArray[i]);

            return countArray;
        }
    }
}