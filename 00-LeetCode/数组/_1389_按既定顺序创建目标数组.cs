using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/create-target-array-in-the-given-order/
    /// </summary>
    public class _1389_按既定顺序创建目标数组
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> target = new List<int>(nums.Length);
            for(int i = 0; i < nums.Length; i++)
            {
                target.Insert(index[i], nums[i]);
            }

            return target.ToArray();
        }
    }
}
