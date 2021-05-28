using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/number-complement/
    /// </summary>
    public class _476_数字的补数
    {
        public int FindComplement(int num)
        {
            int ans = 0;
            for(int i = 0; num != 0; i++)
            {
                ans += ((num & 1) ^ 1) << i;
                num >>= 1;
            }

            return ans;
        }
    }
}
