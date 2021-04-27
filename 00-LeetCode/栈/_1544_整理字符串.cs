using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /**
     * https://leetcode-cn.com/problems/make-the-string-great/
     */
    public class _1544_整理字符串
    {
        // 'a' - 'A' = 32
        public string MakeGood(string s)
        {
            var stack = new Stack<char>();

            foreach(var e in s)
            {
                if (stack.Count > 0 && Math.Abs(e - stack.Peek()) == 32)
                    stack.Pop();
                else
                    stack.Push(e);
            }

            if (stack.Count == 0)
                return string.Empty;

            var reverse = new Stack<char>();
            while (stack.Count > 0)
                reverse.Push(stack.Pop());

            var sb = new StringBuilder();
            while (reverse.Count > 0)
                sb.Append(reverse.Pop());

            return sb.ToString();
        }
    }
}
