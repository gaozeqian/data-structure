using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/1-bit-and-2-bit-characters/
    /// </summary>
    public class _717_1比特与2比特字符
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            if (bits.Length == 1)
                return true;

            int index = -1;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1)
                {
                    index = i;
                    i++;
                }
            }

            if (index == bits.Length - 2)
                return false;
            else
                return true;
        }
    }
}
