using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/minimum-value-to-get-positive-step-by-step-sum/
    /// </summary>
    public class _1413_逐步求和得到正数的最小值
    {
        public int MinStartValue(int[] nums)
        {
            int minSum = int.MaxValue;
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;
                if (sum < minSum)
                    minSum = sum;
            }

            return minSum >= 0 ? 1 : 1 - minSum;
        }
    }
}
