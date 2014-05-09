using System.Linq;

namespace Codility.L1.TimeComplexity
{
    public static class PermMissingElem
    {
        public static int solution(int[] A)
        {
            long sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i];

            var expectedSum = (A.LongLength + 1) * (A.LongLength + 2) / 2;
            return (int)(expectedSum - sum);
        }
    }
}