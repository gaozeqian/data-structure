using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/degree-of-an-array/
    /// </summary>
    public class _697_数组的度
    {
        public int FindShortestSubArray(int[] nums)
        {
            if (nums.Length == 1)
                return 1;

            Dictionary<int, List<int>> degree = new Dictionary<int, List<int>>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (degree.ContainsKey(nums[i]))
                    degree[nums[i]].Add(i);
                else
                    degree.Add(nums[i], new List<int>() { i });
            }

            var orderedDegree = degree.OrderByDescending(d => d.Value.Count);
            int maxDegree = orderedDegree.First().Value.Count;
            int minLength = nums.Length;
            foreach (var item in orderedDegree)
            {
                if (item.Value.Count == maxDegree)
                {
                    int tmp = item.Value.Last() - item.Value.First() + 1;
                    if (tmp < minLength)
                        minLength = tmp;
                }
                else
                    break;
            }

            return minLength;
        }
    }
}
