using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    public class _1047_删除字符串中的所有相邻重复项
    {
        /**
         * https://leetcode-cn.com/problems/remove-all-adjacent-duplicates-in-string/
         */
        public string RemoveDuplicates(string S)
        {
            var stack = new Stack<char>();

            foreach(var e in S)
            {
                if (stack.Count > 0 && e.Equals(stack.Peek()))
                    stack.Pop();
                else
                    stack.Push(e);
            }

            if (stack.Count == 0)
                return string.Empty;

            var stackReverse = new Stack<char>();
            while (stack.Count > 0)
                stackReverse.Push(stack.Pop());

            var sb = new StringBuilder();
            while (stackReverse.Count > 0)
                sb.Append(stackReverse.Pop());

            return sb.ToString();
        }
    }
}
