using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/shift-2d-grid/
    /// </summary>
    public class _1260_二维网格迁移
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            for(int i = 0; i < k; i++)
            {
                for(int r = 0; r < grid.Length; r++)
                {
                    int lastColumn = grid[r][grid[r].Length - 1];
                    for(int c = grid[r].Length - 1; c > 0; c--)
                    {
                        grid[r][c] = grid[r][c - 1];
                    }
                    grid[r][0] = lastColumn;
                }

                int lastRow = grid[grid.Length - 1][0];
                for(int r = grid.Length - 1; r > 0; r--)
                {
                    grid[r][0] = grid[r - 1][0];
                }
                grid[0][0] = lastRow;
            }

            return grid;
        }
    }
}
