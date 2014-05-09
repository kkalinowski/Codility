using System.Collections;

namespace Codility.L2.CountingElements
{
    public static class FrogRiverOne
    {
        public static int solution(int X, int[] A)
        {
            var leafsNeeded = X;
            var countArray = new BitArray(X, false);
            for (int i = 0; i < A.Length; i++)
                if (A[i] <= X && !countArray[A[i] - 1])
                {
                    countArray[A[i] - 1] = true;
                    leafsNeeded--;
                    if (leafsNeeded == 0)
                        return i;
                }

            return -1;
        }
    }
}