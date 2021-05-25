using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sum-of-unique-elements/
    /// </summary>
    public class _1748_唯一元素的和
    {
        public int SumOfUnique(int[] nums)
        {
            int[] count = new int[101];
            foreach (int num in nums)
                count[num]++;

            int sum = 0;
            for(int i = 1; i < 101; i++)
            {
                if (count[i] == 1)
                    sum += i;
            }

            return sum;
        }
    }
}
