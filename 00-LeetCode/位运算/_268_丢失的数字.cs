using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/missing-number/
    /// </summary>
    public class _268_丢失的数字
    {
        public int MissingNumber(int[] nums)
        {
            int ans = nums.Length;
            for (int i = 0; i < nums.Length; i++)
                ans ^= i ^ nums[i];
            return ans;
        }
    }
}
