using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/check-if-array-is-sorted-and-rotated/
    /// </summary>
    public class _1752_检查数组是否经排序和轮转得到
    {
        public bool Check(int[] nums)
        {
            int count = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[(i + 1) % nums.Length])
                    count++;
            }

            return count <= 1;
        }
    }
}
