using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/kth-missing-positive-number/
    /// </summary>
    public class _1539_第k个缺失的正整数
    {
        public int FindKthPositive(int[] arr, int k)
        {
            int[] count = new int[2001];
            foreach (int num in arr)
                count[num] = 1;

            for(int i = 1; i < 2001; i++)
            {
                if (count[i] == 0 && --k == 0)
                    return i;
            }

            return 0;
        }
    }
}
