namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/transpose-matrix/
    /// <summary>
    public class _867_转置矩阵
    {
        public int[][] Transpose(int[][] matrix)
        {
            int rLength = matrix.Length;
            int cLength = matrix[0].Length;

            if (rLength == cLength)
            {
                int tmp;

                for (int r = 0, c = 0; r < matrix.Length && c < matrix.Length; r++, c++)
                {
                    for (int x = c + 1, y = r; x < matrix.Length; x++)
                    {
                        tmp = matrix[y][x];
                        matrix[y][x] = matrix[x][y];
                        matrix[x][y] = tmp;
                    }
                }

                return matrix;
            }
            else
            {
                int[][] trans = new int[cLength][];

                for (int r = 0; r < cLength; r++)
                {
                    trans[r] = new int[rLength];

                    for (int c = 0; c < rLength; c++)
                    {
                        trans[r][c] = matrix[c][r];
                    }
                }

                return trans;
            }
        }
    }
}