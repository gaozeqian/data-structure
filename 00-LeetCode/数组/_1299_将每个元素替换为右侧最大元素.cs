using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/replace-elements-with-greatest-element-on-right-side/
    /// </summary>
    public class _1299_将每个元素替换为右侧最大元素
    {
        public int[] ReplaceElements(int[] arr)
        {
            int rightMax = arr[arr.Length - 1];
            arr[arr.Length - 1] = -1;

            for(int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] <= rightMax)
                    arr[i] = rightMax;
                else
                {
                    int max = arr[i];
                    arr[i] = rightMax;
                    rightMax = max;
                }
            }

            return arr;
        }
    }
}
