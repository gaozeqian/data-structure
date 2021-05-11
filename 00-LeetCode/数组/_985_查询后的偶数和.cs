using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sum-of-even-numbers-after-queries/
    /// </summary>
    public class _985_查询后的偶数和
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            int[] answer = new int[queries.Length];
            int sum = 0;

            for(int i = 0; i < A.Length; i++)
            {
                if ((A[i] & 1) == 0)
                    sum += A[i];
            }

            int preVal;
            for(int r = 0; r < queries.Length; r++)
            {
                preVal = A[queries[r][1]];
                if ((preVal & 1) == 0)
                    sum -= preVal;

                A[queries[r][1]] += queries[r][0];
                if ((A[queries[r][1]] & 1) == 0)
                    sum += A[queries[r][1]];

                answer[r] = sum;
            }

            return answer;
        }
    }
}
