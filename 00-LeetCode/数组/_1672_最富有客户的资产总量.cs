using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/richest-customer-wealth/
    /// </summary>
    public class _1672_最富有客户的资产总量
    {
        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            for(int r = 0; r < accounts.Length; r++)
            {
                int sum = 0;
                for (int c = 0; c < accounts[r].Length; c++)
                    sum += accounts[r][c];

                if (sum > max)
                    max = sum;
            }

            return max;
        }
    }
}
