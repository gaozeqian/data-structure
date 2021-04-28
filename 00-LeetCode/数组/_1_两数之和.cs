using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/two-sum/
     */
    public class _1_两数之和
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }
    }
}
