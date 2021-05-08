using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/largest-number-at-least-twice-of-others/
    /// </summary>
    public class _747_至少是其他数字两倍的最大数
    {
        public int DominantIndex(int[] nums)
        {
            if (nums.Length == 1)
                return 0;

            int maxIndex = 0, secValue = int.MinValue;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[maxIndex])
                {
                    secValue = nums[maxIndex];
                    maxIndex = i;
                }
                else if (nums[i] > secValue)
                {
                    secValue = nums[i];
                }
            }

            if ((secValue << 1) <= nums[maxIndex])
                return maxIndex;
            else
                return -1;
        }
    }
}
