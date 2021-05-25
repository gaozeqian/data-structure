using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/
    /// </summary>
    public class _1779_找到最近的有相同X或Y坐标的点
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            int minIndex = -1;
            int minDistance = int.MaxValue;
            for(int i = 0; i < points.Length; i++)
            {
                if(points[i][0] == x || points[i][1] == y)
                {
                    int distance = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                    if(distance < minDistance)
                    {
                        minDistance = distance;
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }
    }
}
