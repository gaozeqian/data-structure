using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-the-difference/
    /// </summary>
    public class _389_找不同
    {
        public char FindTheDifference(string s, string t)
        {
            int ans = 0;

            foreach (char chr in s)
                ans ^= chr;

            foreach (char chr in t)
                ans ^= chr;

            return (char)ans;
        }
    }
}
