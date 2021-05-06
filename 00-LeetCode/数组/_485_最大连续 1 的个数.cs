using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/max-consecutive-ones/
    /// </summary>
    public class _485_最大连续_1_的个数
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int counter = 0, 
                tmp = 0;

            foreach(var num in nums)
            {
                if (num == 1)
                    tmp++;
                else
                {
                    if (tmp > counter)
                        counter = tmp;

                    tmp = 0;
                }
            }

            if (tmp > counter)
                counter = tmp;

            return counter;
        }
    }
}
