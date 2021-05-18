using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/rank-transform-of-an-array/
    /// </summary>
    public class _1331_数组序号转换
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            foreach (int num in arr)
            {
                if (num < minValue) minValue = num;
                if (num > maxValue) maxValue = num;
            }

            int[] count = new int[maxValue - minValue + 1];
            foreach(int num in arr)
            {
                count[num - minValue] = 1;
            }

            int[] preSum = new int[count.Length + 1];
            for(int i = 1; i < preSum.Length; i++)
            {
                preSum[i] = preSum[i - 1] + count[i - 1];
            }

            int[] answer = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                answer[i] = preSum[arr[i] - minValue] + 1;
            }

            return answer;
        }
    }
}
