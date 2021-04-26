using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    public class _1021_删除最外层的括号
    {
        /**
         * https://leetcode-cn.com/problems/remove-outermost-parentheses/
         */
        public string RemoveOuterParentheses(string S)
        {
            var queue = new Queue<char>();
            int left = 0, right = 0;

            foreach(var e in S)
            {
                if ('('.Equals(e)) left++;
                if (')'.Equals(e)) right++;

                if (left == right)
                {
                    left = right = 0;
                }
                else if(left > 1)
                {
                    queue.Enqueue(e);
                }
            }

            StringBuilder sb = new StringBuilder();
            while (queue.Count > 0)
                sb.Append(queue.Dequeue());

            return sb.ToString();
        }
    }
}
