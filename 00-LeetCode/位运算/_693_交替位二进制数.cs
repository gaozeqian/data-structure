using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/binary-number-with-alternating-bits/
    /// </summary>
    public class _693_交替位二进制数
    {
        public bool HasAlternatingBits(int n)
        {
            int last = n % 2;
            while (n != 0)
            {
                n /= 2;
                int pre = n % 2;
                if (last == pre)
                    return false;

                last = pre;
            }

            return true;
        }
    }
}
