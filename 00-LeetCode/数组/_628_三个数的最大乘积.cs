using System;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/maximum-product-of-three-numbers/
    /// </summary>
    public class _628_三个数的最大乘积
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);

            if (nums[0] >= 0 || nums[nums.Length - 1] <= 0)
                return nums[nums.Length - 3] * nums[nums.Length - 2] * nums[nums.Length - 1];
            else
                return Math.Max(nums[0] * nums[1], nums[nums.Length - 3] * nums[nums.Length - 2]) * nums[nums.Length - 1];
        }
    }
}
