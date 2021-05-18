using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/the-k-weakest-rows-in-a-matrix/
    /// </summary>
    public class _1337_矩阵中战斗力最弱的K行
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            int[] soldier = new int[mat.Length];
            for (int r = 0; r < mat.Length; r++)
            {
                for (int c = 0; c < mat[r].Length; c++)
                    if (mat[r][c] == 1) soldier[r]++;
            }

            int[] ordered = new int[soldier.Length];
            Array.Copy(soldier, ordered, soldier.Length);
            Array.Sort(ordered);

            int[] answer = new int[k];
            for (int i = 0; i < k; i++)
            {
                answer[i] = Array.IndexOf(soldier, ordered[i]);

                if (i > 0 && ordered[i] == ordered[i - 1])
                    answer[i] = Array.IndexOf(soldier, ordered[i], answer[i - 1] + 1);
            }

            return answer;
        }
    }
}
