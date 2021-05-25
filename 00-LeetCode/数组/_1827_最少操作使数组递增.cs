using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/minimum-operations-to-make-the-array-increasing/
    /// </summary>
    public class _1827_最少操作使数组递增
    {
        public int MinOperations(int[] nums)
        {
            int count = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    int newVal = nums[i - 1] + 1;
                    count += newVal - nums[i];
                    nums[i] = newVal;
                }
            }

            return count;
        }
    }
}
