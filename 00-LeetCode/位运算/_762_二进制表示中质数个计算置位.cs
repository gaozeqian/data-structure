using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/prime-number-of-set-bits-in-binary-representation/
    /// </summary>
    public class _762_二进制表示中质数个计算置位
    {
        public int CountPrimeSetBits(int left, int right)
        {
            List<int> primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 };
            int ans = 0;
            for(int i = left; i <= right; i++)
            {
                int tmp = i;
                int count = 0;
                while(tmp != 0)
                {
                    count++;
                    tmp &= tmp - 1;
                }
                if (primes.Contains(count))
                    ans++;
            }
            return ans;
        }
    }
}
