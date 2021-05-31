using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/decode-xored-array/
    /// </summary>
    public class _1720_解码异或后的数组
    {
        public int[] Decode(int[] encoded, int first)
        {
            int[] arr = new int[encoded.Length + 1];
            arr[0] = first;

            for (int i = 0; i < encoded.Length; i++)
                arr[i + 1] = arr[i] ^ encoded[i];

            return arr;
        }
    }
}
