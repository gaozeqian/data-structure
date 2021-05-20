using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/can-make-arithmetic-progression-from-sequence/
    /// </summary>
    public class _1502_判断能否形成等差数列
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int diff = arr[1] - arr[0];
            for(int i = 2; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != diff)
                    return false;
            }

            return true;
        }
    }
}
