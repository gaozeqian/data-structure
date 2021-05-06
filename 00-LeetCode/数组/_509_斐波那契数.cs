using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/fibonacci-number/
    /// </summary>
    public class _509_斐波那契数
    {
        public int Fib(int n)
        {
            if (n <= 1)
                return n;
            else
            {
                int zero = 0, first = 1;

                for (int i = 0; i < n - 1; i++)
                {
                    int sum = zero + first;
                    zero = first;
                    first = sum;
                }

                return first;
            }
        }
    }
}
