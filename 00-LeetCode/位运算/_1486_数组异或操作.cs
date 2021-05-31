using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/xor-operation-in-an-array/
    /// </summary>
    public class _1486_数组异或操作
    {
        public int XorOperation(int n, int start)
        {
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    answer = start + 2 * i;
                else
                    answer = answer ^ (start + 2 * i);
            }

            return answer;
        }
    }
}
