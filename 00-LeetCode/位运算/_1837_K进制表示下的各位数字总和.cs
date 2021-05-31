using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sum-of-digits-in-base-k/
    /// </summary>
    public class _1837_K进制表示下的各位数字总和
    {
        public int SumBase(int n, int k)
        {
            int ans = 0;
            while (n != 0)
            {
                ans += n % k;
                n /= k;
            }

            return ans;
        }
    }
}
