using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/maximum-product-of-two-elements-in-an-array/
    /// </summary>
    public class _1464_数组中两元素的最大乘积
    {
        public int MaxProduct(int[] nums)
        {
            Array.Sort(nums);
            return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);
        }
    }
}
