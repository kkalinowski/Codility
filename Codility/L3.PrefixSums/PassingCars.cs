using System.Collections;

namespace Codility.L3.PrefixSums
{
    public static class PassingCars
    {
        public static int solution(int[] A)
        {
            var mult = 0;
            var pairs = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    mult++;
                else
                {
                    pairs += mult;
                    if (pairs > 1000000000)
                        return -1;
                }
            }

            return pairs;
        }
    }
}