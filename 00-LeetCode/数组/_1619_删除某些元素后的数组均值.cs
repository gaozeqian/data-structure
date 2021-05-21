using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/mean-of-array-after-removing-some-elements/
    /// </summary>
    public class _1619_删除某些元素后的数组均值
    {
        public double TrimMean(int[] arr)
        {
            Array.Sort(arr);

            int start = arr.Length * 5 / 100;
            int end = arr.Length - start;
            int sum = 0;
            for (int i = start; i < end; i++)
                sum += arr[i];

            return sum / (double)(end - start);
        }
    }
}
