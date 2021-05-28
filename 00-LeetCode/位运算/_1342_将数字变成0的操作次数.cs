using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    /// </summary>
    public class _1342_将数字变成0的操作次数
    {
        public int NumberOfSteps(int num)
        {
            int ans = 0;
            while(num > 0)
            {
                ans++;

                if ((num & 1) == 0)
                    num /= 2;
                else
                    num -= 1;
            }

            return ans;
        }
    }
}
