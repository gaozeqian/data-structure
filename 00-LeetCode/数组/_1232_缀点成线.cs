using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/check-if-it-is-a-straight-line/
    /// </summary>
    public class _1232_缀点成线
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            int diffX = coordinates[1][0] - coordinates[0][0];
            int diffY = coordinates[1][1] - coordinates[0][1];

            if(diffX == 0)
            {
                for(int i = 2; i < coordinates.Length; i++)
                {
                    if (coordinates[i][0] != coordinates[0][0])
                        return false;
                }
            }
            else if(diffY == 0)
            {
                for(int i = 2; i < coordinates.Length; i++)
                {
                    if (coordinates[i][1] != coordinates[0][1])
                        return false;
                }
            }
            else
            {
                double k = diffY / (double)diffX;
                for(int i = 2; i < coordinates.Length; i++)
                {
                    if ((coordinates[i][1] - coordinates[0][1]) / (double)(coordinates[i][0] - coordinates[0][0]) != k)
                        return false;
                }
            }

            return true;
        }
    }
}
