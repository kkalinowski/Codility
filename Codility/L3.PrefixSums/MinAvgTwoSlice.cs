namespace Codility.L3.PrefixSums
{
    public static class MinAvgTwoSlice
    {
        //http://codesays.com/2014/solution-to-min-avg-two-slice-by-codility/
        public static int solution(int[] A)
        {
            var min = double.MaxValue;
            var index = 0;

            for (int i = 0; i < A.Length - 2; i++)
            {
                if ((A[i] + A[i + 1]) / 2.0 < min)
                {
                    min = (A[i] + A[i + 1]) / 2.0;
                    index = i;
                }

                if ((A[i] + A[i + 1] + A[i + 2]) / 3.0 < min)
                {
                    min = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    index = i;
                }
            }

            if ((A[A.Length - 2] + A[A.Length - 1]) / 2.0 < min)
                index = A.Length - 2;

            return index;
        }
    }
}