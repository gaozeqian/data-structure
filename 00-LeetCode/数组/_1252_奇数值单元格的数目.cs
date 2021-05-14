using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/cells-with-odd-values-in-a-matrix/
    /// </summary>
    public class _1252_奇数值单元格的数目
    {
        public int OddCells(int m, int n, int[][] indices)
        {
            int[][] matrix = new int[m][];
            for(int i = 0; i < m; i++)
            {
                matrix[i] = new int[n];
            }

            Dictionary<int, int> row = new Dictionary<int, int>();
            Dictionary<int, int> column = new Dictionary<int, int>();
            for(int i = 0; i < indices.Length; i++)
            {
                if (row.ContainsKey(indices[i][0]))
                    row[indices[i][0]]++;
                else
                    row.Add(indices[i][0], 1);

                if (column.ContainsKey(indices[i][1]))
                    column[indices[i][1]]++;
                else
                    column.Add(indices[i][1], 1);
            }

            for(int r = 0; r < matrix.Length; r++)
            {
                for(int c = 0; c < matrix[0].Length; c++)
                {
                    matrix[r][c] = (row.TryGetValue(r, out int rIncrement) ? rIncrement : 0) + (column.TryGetValue(c, out int cIncrement) ? cIncrement : 0);
                }
            }

            int oddCount = 0;
            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[0].Length; c++)
                {
                    if ((matrix[r][c] & 1) == 1)
                        oddCount++;
                }
            }

            return oddCount;
        }
    }
}
