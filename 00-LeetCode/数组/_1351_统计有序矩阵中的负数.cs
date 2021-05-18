using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/count-negative-numbers-in-a-sorted-matrix/
    /// </summary>
    public class _1351_统计有序矩阵中的负数
    {
        public int CountNegatives(int[][] grid)
        {
            int negCount = 0;
            for(int r = 0; r < grid.Length; r++)
            {
                for(int c = grid[r].Length - 1; c >= 0; c--)
                {
                    if (grid[r][c] < 0)
                        negCount++;
                    else
                        break;
                }
            }

            return negCount;
        }
    }
}
