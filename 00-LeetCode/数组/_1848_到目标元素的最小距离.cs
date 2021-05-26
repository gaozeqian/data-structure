using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/minimum-distance-to-the-target-element/
    /// </summary>
    public class _1848_到目标元素的最小距离
    {
        public int GetMinDistance(int[] nums, int target, int start)
        {
            int min = int.MaxValue;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    int abs = Math.Abs(i - start);
                    if (abs < min)
                        min = abs;
                }
            }

            return min;
        }
    }
}
