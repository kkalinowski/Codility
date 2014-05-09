using System.Collections;
using System.Linq;

namespace Codility.L3.PrefixSums
{
    public static class GenomicRangeQuery
    {
        public static int[] solution(string S, int[] P, int[] Q)
        {
            var M = P.Length;
            var N = S.Length;
            var prefixSum = new int[N + 1, 4];
            var result = new int[M];

            var firstSymbol = ConvertSymbolIntoImpactFactor(S[0]) - 1;
            prefixSum[0, firstSymbol] = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 4; j++)
                    prefixSum[i + 1, j] = prefixSum[i, j];

                prefixSum[i + 1, ConvertSymbolIntoImpactFactor(S[i]) - 1]++;
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (prefixSum[Q[i] + 1, j] - prefixSum[P[i], j] > 0)
                    {
                        result[i] = j + 1;
                        break;
                    }
                }
            }

            return result;
        }

        private static int ConvertSymbolIntoImpactFactor(char minSymbol)
        {
            if (minSymbol == 'A')
                return 1;
            else if (minSymbol == 'C')
                return 2;
            else if (minSymbol == 'G')
                return 3;
            else
                return 4;
        }
    }
}