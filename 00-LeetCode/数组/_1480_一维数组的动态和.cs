using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/running-sum-of-1d-array/
    /// </summary>
    public class _1480_一维数组的动态和
    {
        public int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];
            int sum = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                runningSum[i] = sum;
            }

            return runningSum;
        }
    }
}
