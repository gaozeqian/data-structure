using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-lucky-integer-in-an-array/
    /// </summary>
    public class _1394_找出数组中的幸运数
    {
        public int FindLucky(int[] arr)
        {
            int minVal = int.MaxValue;
            int maxVal = int.MinValue;
            foreach(int num in arr)
            {
                if (num < minVal)
                    minVal = num;

                if (num > maxVal)
                    maxVal = num;
            }

            int[] count = new int[maxVal - minVal + 1];
            foreach (int num in arr)
                count[num - minVal]++;

            for(int i = count.Length - 1; i >= 0; i--)
            {
                if (count[i] == i + minVal)
                    return count[i];
            }

            return -1;
        }
    }
}
