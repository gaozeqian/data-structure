namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/flipping-an-image/
    /// <summary>
    public class _832_翻转图像
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            int tmp;
            for (int r = 0; r < image.Length; r++)
            {
                for (int i = 0, j = image[r].Length - 1; i <= j; i++, j--)
                {
                    tmp = image[r][i];
                    image[r][i] = image[r][j] == 1 ? 0 : 1;
                    image[r][j] = tmp == 1 ? 0 : 1;
                }
            }
            return image;
        }
    }
}