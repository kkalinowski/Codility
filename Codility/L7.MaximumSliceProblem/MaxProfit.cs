
namespace Codility.L7.MaximumSliceProblem
{
    public static class MaxProfit
    {
        public static int solution(int[] A)
        {
            var N = A.Length;
            if (N < 1)
                return 0;

            var max = 0;
            var result = 0;

            for (int i = N - 1; i >= 0; --i)
            {
                if (A[i] > max)
                    max = A[i];

                var temp = max - A[i];
                if (temp > result)
                    result = temp;
            }

            return result;
        }
    }
}