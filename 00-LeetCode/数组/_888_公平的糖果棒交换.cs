namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/fair-candy-swap/
    /// <summary>
    public class _888_公平的糖果棒交换
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            int sumA = 0, sumB = 0;

            for (int i = 0; i < A.Length; i++)
                sumA += A[i];

            for (int i = 0; i < B.Length; i++)
                sumB += B[i];

            int minus = (sumA - sumB) >> 1;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] - B[j] == minus)
                        return new int[] { A[i], B[j] };
                }
            }

            return null;
        }
    }
}