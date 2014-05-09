using System.Collections.Generic;

namespace Codility.L5.StacksAndQueues
{
    public static class Brackets
    {
        public static int solution(string S)
        {
            var stack = new Stack<char>();

            foreach (var sign in S)
            {
                if (sign == '(' || sign == '{' || sign == '[')
                {
                    stack.Push(sign);
                    continue;
                }

                if ((sign == ')' || sign == '}' || sign == ']') && stack.Count == 0)
                    return 0;

                if (sign == ')')
                {
                    var prevSign = stack.Pop();
                    if (prevSign != '(')
                        return 0;
                }
                if (sign == '}')
                {
                    var prevSign = stack.Pop();
                    if (prevSign != '{')
                        return 0;
                }
                if (sign == ']')
                {
                    var prevSign = stack.Pop();
                    if (prevSign != '[')
                        return 0;
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}