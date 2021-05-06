using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/array-partition-i/
    /// </summary>
    public class _561_数组拆分1
    {
        public int ArrayPairSum(int[] nums)
        {
            if (nums.Length == 2)
                return Math.Min(nums[0], nums[1]);

            int sum = 0;
            Array.Sort(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                    sum += nums[i];
            }

            return sum;
        }
    }
}
