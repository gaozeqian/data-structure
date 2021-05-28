using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/convert-a-number-to-hexadecimal/
    /// </summary>
    public class _405_数字转换为十六进制数
    {
        public string ToHex(int num)
        {
            if (num == 0)
                return "0";

            uint unum = (uint)num;
            string hex = "0123456789abcdef";
            string ans = string.Empty;
            while (unum != 0)
            {
                ans = hex[(int)(unum & 0xf)] + ans;
                unum >>= 4;
            }

            return ans;
        }
    }
}
