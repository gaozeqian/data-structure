using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/binary-prefix-divisible-by-5/
    /// </summary>
    public class _1018_可被5整除的二进制前缀
    {
        public IList<bool> PrefixesDivBy5(int[] A)
        {
            bool[] answer = new bool[A.Length];
            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                    sum = A[i];
                else
                    sum = (sum << 1) + A[i];

                sum %= 5;
                answer[i] = sum == 0;
            }

            return answer;
        }
    }
}
