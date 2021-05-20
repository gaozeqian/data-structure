using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/three-consecutive-odds/
    /// </summary>
    public class _1550_存在连续三个奇数的数组
    {
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            int oddNums = 0;
            foreach(int num in arr)
            {
                if ((num & 1) == 1)
                {
                    if (++oddNums == 3)
                        return true;
                }
                else
                    oddNums = 0;
            }

            return false;
        }
    }
}
