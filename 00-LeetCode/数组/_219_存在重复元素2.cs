using System;
using System.Collections.Generic;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/contains-duplicate-ii/
     */
    public class _219_存在重复元素2
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    if (i - dic[nums[i]] <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dic[nums[i]] = i;
                    }
                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }

            return false;
        }
    }
}