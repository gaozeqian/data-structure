using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sum-of-all-odd-length-subarrays/
    /// </summary>
    public class _1588_所有奇数长度子数组的和
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int sum = 0;
            for (int length = 1; length <= arr.Length; length += 2)
            {
                for (int i = 0; i <= arr.Length - length; i++)
                {
                    for (int j = i; j < i + length; j++)
                        sum += arr[j];
                }
            }

            return sum;
        }
    }
}
