using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/detect-pattern-of-length-m-repeated-k-or-more-times/
    /// </summary>
    public class _1566_重复至少K次且长度为M的模式
    {
        public bool ContainsPattern(int[] arr, int m, int k)
        {
            for (int start = 0; start <= arr.Length - m * k; start++)
            {
                int offset;
                for (offset = 0; offset < m * k; offset++)
                {
                    if (arr[start + offset] != arr[start + offset % m])
                        break;
                }

                if (offset == m * k)
                    return true;
            }

            return false;
        }
    }
}
