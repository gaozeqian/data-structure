using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/matrix-diagonal-sum/
    /// </summary>
    public class _1572_矩阵对角线元素的和
    {
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            int except = 0;

            for(int r = 0, c = 0; r < mat.Length; r++, c++)
            {
                sum += mat[r][c];
            }

            for(int r = 0, c = mat.Length - 1; r < mat.Length; r++, c--)
            {
                sum += mat[r][c];
                if (r == c)
                    except = mat[r][c];
            }

            return sum - except;
        }
    }
}
