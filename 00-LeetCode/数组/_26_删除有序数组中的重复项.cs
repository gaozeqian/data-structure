using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/
     */
    public class _26_删除有序数组中的重复项
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;

            int length = nums.Length;

            for (int i = 1; i < length;)
            {
                if (nums[i - 1] == nums[i])
                {
                    length--;

                    for (int j = i; j < length;)
                    {
                        nums[j] = nums[++j];
                    }

                    continue;
                }

                i++;
            }

            return length;
        }
    }
}
