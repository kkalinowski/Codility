using System.Collections.Generic;

namespace Codility.L5.StacksAndQueues
{
    public static class Fish
    {
        public static int solution(int[] A, int[] B)
        {
            var N = A.Length;
            const int Downstream = 0;
            const int Upstream = 1;

            var alive = 0;
            var upstreamFishes = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (B[i] == Downstream && upstreamFishes.Count == 0)
                {
                    alive++;
                }
                else if (B[i] == Downstream && upstreamFishes.Count != 0)
                {
                    alive += DownstreamFishPassingUpstreamFishes(upstreamFishes, A[i]);
                }
                else if (B[i] == Upstream)
                {
                    upstreamFishes.Add(A[i]);
                }
            }

            return alive + upstreamFishes.Count;
        }

        private static int DownstreamFishPassingUpstreamFishes(List<int> upstreamFishes, int downstreamFish)
        {
            for (int i = upstreamFishes.Count - 1; i >= 0; i--)
            {
                if (downstreamFish < upstreamFishes[i])
                    return 0; //downstream fish was eaten
                else if (downstreamFish > upstreamFishes[i])
                    upstreamFishes.RemoveAt(i);//upstream fish was eaten
                //else continue - fish same sizes
            }

            return 1;
        }
    }
}