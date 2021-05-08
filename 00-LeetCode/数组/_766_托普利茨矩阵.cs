using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/toeplitz-matrix/
    /// </summary>
    public class _766_托普利茨矩阵
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int compare;

            for (int r = 0; r < matrix.Length; r++)
            {
                compare = matrix[r][0];

                for (int x = 0, y = r; y < matrix.Length && x < matrix[0].Length; x++, y++)
                {
                    if (matrix[y][x] != compare)
                        return false;
                }
            }

            for (int c = 1; c < matrix[0].Length; c++)
            {
                compare = matrix[0][c];

                for (int x = c, y = 0; y < matrix.Length && x < matrix[0].Length; x++, y++)
                {
                    if (matrix[y][x] != compare)
                        return false;
                }
            }

            return true;
        }
    }
}
