using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.位运算
{
    /// <summary>
    /// https://leetcode-cn.com/problems/single-number/
    /// </summary>
    public class _136_只出现一次的数字
    {
        public int SingleNumber(int[] nums)
        {
            int single = 0;
            foreach (int num in nums)
                single ^= num;
            return single;
        }
    }
}
