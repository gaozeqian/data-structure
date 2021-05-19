using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/shuffle-the-array/
    /// </summary>
    public class _1470_重新排列数组
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] answer = new int[nums.Length];
            int index = 0;
            for(int i = 0, j = n; i < n && j < nums.Length; i++, j++)
            {
                answer[index++] = nums[i];
                answer[index++] = nums[j];
            }

            return answer;
        }
    }
}
