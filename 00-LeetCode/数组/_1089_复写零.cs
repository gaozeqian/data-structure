using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/duplicate-zeros/
    /// </summary>
    public class _1089_复写零
    {
        public void DuplicateZeros(int[] arr)
        {
            int[] answer = new int[arr.Length];
            for (int i = 0, j = 0; i < arr.Length && j < arr.Length; i++)
            {
                if (arr[i] == 0)
                    j += 2;
                else
                    answer[j++] = arr[i];
            }
            Array.Copy(answer, arr, arr.Length);
        }
    }
}
