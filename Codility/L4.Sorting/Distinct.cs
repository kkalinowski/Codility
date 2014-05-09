using System.Linq;

namespace Codility.L4.Sorting
{
    public static class Distinct
    {
        public static int solution(int[] A)
        {
            var N = A.Length;
            if (N == 0)
                return 0;

            var sorted = A.OrderBy(x => x).ToArray();
            var distinct = 1;
            var last = sorted.First();

            for (int i = 1; i < N; i++)
            {
                if (sorted[i] != last)
                {
                    distinct++;
                    last = sorted[i];
                }
            }

            return distinct;
        }
    }
}