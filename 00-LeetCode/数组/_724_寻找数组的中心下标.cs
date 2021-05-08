using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-pivot-index/
    /// </summary>
    public class _724_寻找数组的中心下标
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length == 1)
                return 0;

            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            int tmp = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (tmp * 2 + nums[i] == sum)
                    return i;

                tmp += nums[i];
            }

            return -1;
        }
    }
}
