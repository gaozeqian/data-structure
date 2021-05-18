using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/lucky-numbers-in-a-matrix/
    /// </summary>
    public class _1380_矩阵中的幸运数
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            List<int> answer = new List<int>();
            for(int r = 0; r < matrix.Length; r++)
            {
                int rowMin = int.MaxValue;
                int columnIndex = -1;
                for(int c = 0; c < matrix[r].Length; c++)
                {
                    if (matrix[r][c] < rowMin)
                    {
                        rowMin = matrix[r][c];
                        columnIndex = c;
                    }
                }

                bool isMax = true;
                for(int r2 = 0; r2 < matrix.Length; r2++)
                {
                    if (matrix[r2][columnIndex] > rowMin)
                    {
                        isMax = false;
                        break;
                    }
                }

                if (isMax)
                    answer.Add(rowMin);
            }

            return answer;
        }
    }
}
