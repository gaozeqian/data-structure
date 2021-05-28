using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/hamming-distance/
    /// </summary>
    public class _461_汉明距离
    {
        public int HammingDistance(int x, int y)
        {
            x ^= y;
            int ans = 0;
            while(x != 0)
            {
                ans++;
                x &= x - 1;
            }

            return ans;
        }
    }
}
