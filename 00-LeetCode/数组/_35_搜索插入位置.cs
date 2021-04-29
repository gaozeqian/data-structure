using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/search-insert-position/
     */
    public class _35_搜索插入位置
    {
        public int SearchInsert(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                    return i;
            }

            return nums.Length;
        }
    }
}
