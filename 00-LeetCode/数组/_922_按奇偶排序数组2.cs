using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sort-array-by-parity-ii/
    /// </summary>
    public class _922_按奇偶排序数组2
    {
        public int[] SortArrayByParityII(int[] nums)
        {
            int[] sortedNums = new int[nums.Length];
            int evenIndex = 0, oddIndex = 1;

            foreach(int num in nums)
            {
                if ((num & 1) == 0)
                {
                    sortedNums[evenIndex] = num;
                    evenIndex += 2;
                }
                else
                {
                    sortedNums[oddIndex] = num;
                    oddIndex += 2;
                }
            }

            return sortedNums;
        }
    }
}
