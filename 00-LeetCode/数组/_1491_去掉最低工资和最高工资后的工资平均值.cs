using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
    /// </summary>
    public class _1491_去掉最低工资和最高工资后的工资平均值
    {
        public double Average(int[] salary)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            foreach(int num in salary)
            {
                sum += num;

                if (num < min)
                    min = num;

                if (num > max)
                    max = num;
            }

            return (sum - min - max) / (double)(salary.Length - 2);
        }
    }
}
