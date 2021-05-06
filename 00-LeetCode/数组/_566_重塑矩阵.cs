using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/reshape-the-matrix/
    /// </summary>
    public class _566_重塑矩阵
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length * mat[0].Length != r * c)
                return mat;

            var nums = mat.SelectMany(n => n);
            int[][] array = new int[r][];
            
            for(int i = 0; i < r; i++)
            {
                array[i] = nums.Skip(i * c).Take(c).ToArray();
            }

            return array;
        }
    }
}
