using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/get-maximum-in-generated-array/
    /// </summary>
    public class _1646_获取生成数组中的最大值
    {
        public int GetMaximumGenerated(int n)
        {
            if (n <= 1)
                return n;

            int[] nums = new int[n + 1];
            nums[1] = 1;
            int max = 0;
            for(int i = 2; i <= n; i++)
            {
                if ((i & 1) == 0)
                    nums[i] = nums[i >> 1];
                else
                    nums[i] = nums[(i - 1) >> 1] + nums[((i - 1) >> 1) + 1];

                if (nums[i] > max)
                    max = nums[i];
            }

            return max;
        }
    }
}
