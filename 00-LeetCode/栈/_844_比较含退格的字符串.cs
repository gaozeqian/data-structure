using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /**
     * https://leetcode-cn.com/problems/backspace-string-compare/
     */
    public class _844_比较含退格的字符串
    {
        public bool BackspaceCompare(string s, string t)
        {
            var s_stack = new Stack<char>();
            var t_stack = new Stack<char>();

            foreach (var e in s)
            {
                if ('#'.Equals(e))
                {
                    if (s_stack.Count > 0)
                        s_stack.Pop();
                }
                else
                {
                    s_stack.Push(e);
                }

            }

            foreach (var e in t)
            {
                if ('#'.Equals(e))
                {
                    if (t_stack.Count > 0)
                        t_stack.Pop();
                }
                else
                {
                    t_stack.Push(e);
                }
            }

            if (!s_stack.Count.Equals(t_stack.Count))
                return false;

            while (s_stack.Count > 0)
            {
                if (!s_stack.Pop().Equals(t_stack.Pop()))
                    return false;
            }

            return true;
        }
    }
}
