using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/maximum-population-year/
    /// </summary>
    public class _1854_人口最多的年份
    {
        public int MaximumPopulation(int[][] logs)
        {
            int[] count = new int[101];
            for(int i = 0; i < logs.Length; i++)
            {
                int start = logs[i][0] - 1950;
                int end = logs[i][1] - 1950;

                for (int j = start; j < end; j++)
                    count[j]++;
            }

            int max = 0;
            int yeah = 0;
            for(int i = 0; i < 101; i++)
            {
                if(count[i] > max)
                {
                    max = count[i];
                    yeah = i;
                }
            }

            return yeah + 1950;
        }
    }
}
