using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/reverse-bits/
    /// </summary>
    public class _190_颠倒二进制位
    {
        public uint reverseBits(uint n)
        {
            uint ans = 0;
            for(int i = 0; i < 32 && n != 0; i++)
            {
                ans |= (n & 1) << (31 - i);
                n >>= 1;
            }
            return ans;
        }
    }
}
