using System.Linq;

namespace Codility.L4.Sorting
{
    public static class Triangle
    {
        public static int solution(int[] A)
        {
            var N = A.Length;
            if (N < 3)
                return 0;

            var p = 0;
            var q = 1;
            var r = 2;
            var sorted = A.Where(x => x > 0).OrderBy(x => x).ToArray();

            for (; r < sorted.Length; p++, q++, r++)
                if (sorted[p] > (sorted[r] - sorted[q]))
                    return 1;

            return 0;
        }
    }
}