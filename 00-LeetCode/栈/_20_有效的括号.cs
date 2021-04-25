using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /*
     * https://leetcode-cn.com/problems/valid-parentheses/
     */
    public class _20_有效的括号
    {
        public bool IsValid(string s)
        {
            var dic = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            var stack = new Stack<char>();
            foreach(var e in s.ToCharArray())
            {
                if (dic.ContainsKey(e))
                {
                    stack.Push(e);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;
                    else if (!e.Equals(dic[stack.Pop()]))
                        return false;
                }
            }

            if (stack.Count > 0)
                return false;
            else
                return true;
        }
    }
}
