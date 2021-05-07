using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/maximum-average-subarray-i/
    /// </summary>
    public class _643_子数组最大平均数1
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            if (nums.Length == k)
                return nums.Sum() / (double)k;

            int sum = 0, tmp = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(i < k)
                {
                    tmp += nums[i];
                    sum = tmp;
                }
                else
                {
                    tmp -= nums[i - k];
                    tmp += nums[i];
                    if (tmp > sum)
                        sum = tmp;
                }
            }

            return sum / (double)k;
        }
    }
}
