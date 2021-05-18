using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-numbers-with-even-number-of-digits/
    /// </summary>
    public class _1295_统计位数为偶数的数字
    {
        public int FindNumbers(int[] nums)
        {
            int answer = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                int tmp = 0;
                while(nums[i] != 0)
                {
                    tmp++;
                    nums[i] /= 10;
                }

                if ((tmp & 1) == 0)
                    answer++;
            }

            return answer;
        }
    }
}
