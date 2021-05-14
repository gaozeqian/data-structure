using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/distance-between-bus-stops/
    /// </summary>
    public class _1184_公交站间的距离
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int sum = 0;
            for(int i = 0; i < distance.Length; i++)
            {
                sum += distance[i];
            }

            int way = 0;
            for(int i = Math.Min(start, destination); i < Math.Max(start, destination); i++)
            {
                way += distance[i];
            }

            return Math.Min(way, sum - way);
        }
    }
}
