using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sort-array-by-parity/
    /// </summary>
    public class _905_按奇偶排序数组
    {
        public int[] SortArrayByParity(int[] A)
        {
            if (A.Length == 1)
                return A;

            List<int> even = new List<int>(A.Length);
            List<int> odd = new List<int>(A.Length);

            foreach(var num in A)
            {
                if ((num & 1) == 0)
                    even.Add(num);
                else
                    odd.Add(num);
            }

            even.AddRange(odd);
            return even.ToArray();
        }
    }
}
