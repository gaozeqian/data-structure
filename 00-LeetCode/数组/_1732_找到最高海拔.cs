using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-the-highest-altitude/
    /// </summary>
    public class _1732_找到最高海拔
    {
        public int LargestAltitude(int[] gain)
        {
            int max = int.MinValue;
            int sum = 0;
            for(int i = 0; i < gain.Length; i++)
            {
                sum += gain[i];
                if (sum > max)
                    max = sum;
            }

            return Math.Max(0, max);
        }
    }
}
