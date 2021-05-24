using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sort-array-by-increasing-frequency/
    /// </summary>
    public class _1636_按照频率将数组升序排序
    {
        public int[] FrequencySort(int[] nums)
        {
            int[] freq = new int[201];
            foreach (int num in nums)
                freq[num + 100]++;

            int min = 201;
            int max = 1;
            foreach(int num in freq)
            {
                if (num < min)
                    min = num;

                if (num > max)
                    max = num;
            }

            int[] ans = new int[nums.Length];
            int index = 0;
            for(int i = min; i <= max; i++)
            {
                for(int j = 200; j >= 0; j--)
                {
                    if(freq[j] == i)
                    {
                        for (int k = 0; k < i; k++)
                            ans[index++] = j - 100;
                    }
                }
            }

            return ans;
        }
    }
}
