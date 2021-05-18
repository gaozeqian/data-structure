using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/element-appearing-more-than-25-in-sorted-array/
    /// </summary>
    public class _1287_有序数组中出现次数超过百分之二十五的元素
    {
        public int FindSpecialInteger(int[] arr)
        {
            int element = arr[0];
            int minLength = arr.Length / 4;
            int length = 1;
            
            for(int i = 1; i < arr.Length; i++)
            {
                if (length > minLength)
                    break;

                if (arr[i] == element)
                    length++;
                else
                {
                    element = arr[i];
                    length = 1;
                }
            }

            return element;
        }
    }
}
