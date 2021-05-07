using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/longest-continuous-increasing-subsequence/
    /// </summary>
    public class _674_最长连续递增序列
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;

            int maxLength = 1, tmpLength = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                    tmpLength++;
                else
                {
                    if (tmpLength > maxLength)
                        maxLength = tmpLength;

                    tmpLength = 1;
                }
            }

            return Math.Max(maxLength, tmpLength);
        }
    }
}
