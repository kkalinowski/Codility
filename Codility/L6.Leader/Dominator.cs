using System.Linq;

namespace Codility.L6.Leader
{
    public static class Dominator
    {
        public static int solution(int[] A)
        {
            var N = A.Length;
            var stackValue = 0;
            var stackSize = 0;
            var candidateIndex = -1;

            for (int i = 0; i < N; i++)
            {
                if (stackSize == 0)
                {
                    stackValue = A[i];
                    stackSize++;
                    candidateIndex = i;
                }
                else
                {
                    if (stackValue != A[i])
                        stackSize--;
                    else
                        stackSize++;
                }
            }

            if (stackSize == 0)
                return -1;

            return A.Count(x => x == stackValue) > N / 2.0 ? candidateIndex : -1;
        }
    }
}