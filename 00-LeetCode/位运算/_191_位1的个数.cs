using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/number-of-1-bits/
    /// </summary>
    public class _191_位1的个数
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            for(int i = 0; i < 32 && n != 0; i++)
            {
                if ((n & 1) == 1)
                    count++;
                n >>= 1;
            }
            return count;
        }
    }
}
