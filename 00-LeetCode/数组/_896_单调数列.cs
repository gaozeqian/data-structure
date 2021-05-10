using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/monotonic-array/
    /// </summary>
    public class _896_单调数列
    {
        public bool IsMonotonic(int[] A)
        {
            if (A.Length <= 2)
                return true;

            bool? increasement = null;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i - 1] != A[i])
                {
                    if (increasement.HasValue && increasement.Value != A[i - 1] < A[i])
                        return false;
                    else
                        increasement = A[i - 1] < A[i];
                }
            }

            return true;
        }
    }
}
