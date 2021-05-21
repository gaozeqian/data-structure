using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
    /// </summary>
    public class _1608_特殊数组的特征值
    {
        public int SpecialArray(int[] nums)
        {
            int[] count = new int[1001];
            foreach (int num in nums)
                count[num]++;

            int sum = 0;
            int min = 1000;
            for (int i = 1000; i >= 0; i--)
            {
                if (count[i] != 0)
                {
                    if (sum > i && sum <= min)
                        return sum;

                    sum += count[i];
                    min = i;
                }
            }

            if (nums.Length <= min)
                return nums.Length;
            else
                return -1;
        }
    }
}
