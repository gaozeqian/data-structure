using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/minimum-changes-to-make-alternating-binary-string/
    /// </summary>
    public class _1758_生成交替二进制字符串的最少操作数
    {
        public int MinOperations(string s)
        {
            int startZero = 0;
            int startOne = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if ((i & 1) == 0 && s[i] == '1')
                    startZero++;

                if ((i & 1) == 1 && s[i] == '0')
                    startZero++;

                if ((i & 1) == 0 && s[i] == '0')
                    startOne++;

                if ((i & 1) == 1 && s[i] == '1')
                    startOne++;
            }

            return Math.Min(startZero, startOne);
        }
    }
}
