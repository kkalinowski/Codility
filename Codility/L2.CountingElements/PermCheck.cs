using System.Collections;
using System.Linq;

namespace Codility.L2.CountingElements
{
    public static class PermCheck
    {
        public static int solution(int[] A)
        {
            var countArray = new BitArray(A.Length, false);
            for (int i = 0; i < A.Length; i++)
                if (A[i] > A.Length || countArray[A[i] - 1])
                    return 0;
                else
                    countArray[A[i] - 1] = true;

            return 1;
        }
    }
}