using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sort-integers-by-the-number-of-1-bits/
    /// </summary>
    public class _1356_根据数字二进制下1的数目排序
    {
        public int[] SortByBits(int[] arr)
        {
            int[] bit = new int[10001];
            foreach (int num in arr)
                bit[num] = GetBinDigits(num);

            Array.Sort(arr, (n1, n2) =>
            {
                if (bit[n1] != bit[n2])
                    return bit[n1] - bit[n2];
                else
                    return n1 - n2;
            });

            return arr;
        }

        private int GetBinDigits(int dec)
        {
            int digits = 0;
            while(dec != 0)
            {
                digits++;
                dec &= dec - 1;
            }

            return digits;
        }
    }
}
