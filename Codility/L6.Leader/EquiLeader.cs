using System.Linq;

namespace Codility.L6.Leader
{
    public static class EquiLeader
    {
        public static int solution(int[] A)
        {
            var N = A.Length;
            var leader = FindCandidateForLeader(A);
            var leaderCount = A.Count(x => x == leader);

            if (leaderCount <= N / 2.0)
                return 0;

            var currentLeaderCount = 0;
            var equiLeadersCount = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == leader)
                    currentLeaderCount++;

                if (currentLeaderCount > (i + 1) / 2.0 && (leaderCount - currentLeaderCount) > (N - i - 1) / 2.0)
                    equiLeadersCount++;
            }

            return equiLeadersCount;
        }

        private static int FindCandidateForLeader(int[] A)
        {
            var N = A.Length;
            var stackValue = 0;
            var stackSize = 0;

            for (int i = 0; i < N; i++)
            {
                if (stackSize == 0)
                {
                    stackValue = A[i];
                    stackSize++;
                }
                else
                {
                    if (stackValue != A[i])
                        stackSize--;
                    else
                        stackSize++;
                }
            }

            return stackValue;
        }
    }
}