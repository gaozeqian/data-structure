using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/how-many-numbers-are-smaller-than-the-current-number/
    /// </summary>
    public class _1365_有多少小于当前数字的数字
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int minVal = int.MaxValue;
            int maxVal = int.MinValue;
            foreach(int num in nums)
            {
                if (num < minVal) minVal = num;
                if (num > maxVal) maxVal = num;
            }

            int[] count = new int[maxVal - minVal + 1];
            foreach (int num in nums)
                count[num - minVal]++;

            int[] preSum = new int[count.Length + 1];
            for (int i = 1; i < preSum.Length; i++)
                preSum[i] = preSum[i - 1] + count[i - 1];

            int[] answer = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                answer[i] = preSum[nums[i] - minVal];

            return answer;
        }
    }
}
