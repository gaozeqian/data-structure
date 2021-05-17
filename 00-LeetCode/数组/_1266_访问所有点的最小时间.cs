using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/minimum-time-visiting-all-points/
    /// </summary>
    public class _1266_访问所有点的最小时间
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int minTime = 0;
            for(int i = 1; i < points.Length; i++)
            {
                minTime += Math.Max(Math.Abs(points[i][0] - points[i - 1][0]), Math.Abs(points[i][1] - points[i - 1][1]));
            }

            return minTime;
        }
    }
}
