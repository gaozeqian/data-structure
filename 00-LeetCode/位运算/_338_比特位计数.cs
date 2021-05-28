using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/counting-bits/
    /// </summary>
    public class _338_比特位计数
    {
        public int[] CountBits(int n)
        {
            int[] bits = new int[n + 1];
            for(int i = 0; i <= n; i++)
            {
                bits[i] = CountOnes(i);
            }
            return bits;
        }

        private int CountOnes(int n)
        {
            int ones = 0;
            while(n > 0)
            {
                ones++;
                n &= n - 1;
            }
            return ones;
        }
    }
}
