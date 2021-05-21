using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/special-positions-in-a-binary-matrix/
    /// </summary>
    public class _1582_二进制矩阵中的特殊位置
    {
        public int NumSpecial(int[][] mat)
        {
            Dictionary<int, int> rSum = new Dictionary<int, int>();
            for (int r = 0; r < mat.Length; r++)
            {
                int sum = 0;
                for (int c = 0; c < mat[r].Length; c++)
                    sum += mat[r][c];
                rSum.Add(r, sum);
            }

            Dictionary<int, int> cSum = new Dictionary<int, int>();
            for (int c = 0; c < mat[0].Length; c++)
            {
                int sum = 0;
                for (int r = 0; r < mat.Length; r++)
                    sum += mat[r][c];
                cSum.Add(c, sum);
            }

            int answer = 0;
            for (int r = 0; r < mat.Length; r++)
            {
                if (rSum[r] == 1)
                {
                    for (int c = 0; c < mat[r].Length; c++)
                    {
                        if (cSum[c] == 1 && mat[r][c] == 1)
                            answer++;
                    }
                }
            }

            return answer;
        }
    }
}
