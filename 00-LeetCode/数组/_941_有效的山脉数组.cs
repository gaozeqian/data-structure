using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/valid-mountain-array/
    /// </summary>
    public class _941_有效的山脉数组
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
                return false;

            bool isIncrement = true;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                    return false;

                if (isIncrement && (arr[i - 1] > arr[i]))
                    isIncrement = false;

                if (!isIncrement && (arr[i - 1] < arr[i]))
                    return false;
            }

            return !isIncrement && (arr[0] < arr[1]);
        }
    }
}
