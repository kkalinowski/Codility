using System;

namespace Codility.L1.TimeComplexity
{
    public static class FrogJmp
    {
        public static int solution(int X, int Y, int D)
        {
            var jumps = (X - Y) / (double)D;
            return (int)Math.Ceiling(jumps);
        }
    }
}
