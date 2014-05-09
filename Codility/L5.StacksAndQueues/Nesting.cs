
namespace Codility.L5.StacksAndQueues
{
    public static class Nesting
    {
        public static int solution(string S)
        {
            var opened = 0;

            foreach (var sign in S)
            {
                if (sign == '(')
                {
                    opened++;
                }
                else if (sign == ')')
                {
                    opened--;
                    if (opened < 0)
                        return 0;
                }
            }

            return opened == 0 ? 1 : 0;
        }
    }
}