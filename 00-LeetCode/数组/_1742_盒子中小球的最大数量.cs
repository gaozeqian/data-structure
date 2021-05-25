using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/maximum-number-of-balls-in-a-box/
    /// </summary>
    public class _1742_盒子中小球的最大数量
    {
        public int CountBalls(int lowLimit, int highLimit)
        {
            int highDigits = 0;
            int tmpLimit = highLimit;
            while(tmpLimit != 0)
            {
                highDigits++;
                tmpLimit /= 10;
            }
            int highBoxLimit = highDigits * 9;

            int[] count = new int[highBoxLimit + 1];
            for (int i = lowLimit; i <= highLimit; i++)
            {
                int sum = 0;
                int tmp = i;
                while(tmp != 0)
                {
                    sum += tmp % 10;
                    tmp /= 10;
                }
                count[sum]++;
            }

            int max = 0;
            foreach(int num in count)
            {
                if (num > max)
                    max = num;
            }

            return max;
        }
    }
}
