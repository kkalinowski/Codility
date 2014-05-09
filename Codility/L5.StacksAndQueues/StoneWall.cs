using System.Collections.Generic;

namespace Codility.L5.StacksAndQueues
{
    public static class StoneWall
    {
        public static int solution(int[] H)
        {
            var N = H.Length;
            var currentHeight = H[0];
            var foundamentBlocks = new Stack<int>();
            var usedBlocks = 1;
            foundamentBlocks.Push(currentHeight);

            for (var i = 1; i < N; i++)
            {
                while (foundamentBlocks.Count > 0 && H[i] < currentHeight)
                {
                    var lastHeight = foundamentBlocks.Pop();
                    currentHeight -= lastHeight;
                }

                if (H[i] > currentHeight)
                {
                    foundamentBlocks.Push(H[i] - currentHeight);
                    currentHeight = H[i];
                    usedBlocks++;
                }
            }

            return usedBlocks;
        }
    }
}