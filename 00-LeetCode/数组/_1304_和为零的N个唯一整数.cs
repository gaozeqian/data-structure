using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-n-unique-integers-sum-up-to-zero/
    /// </summary>
    public class _1304_和为零的N个唯一整数
    {
        public int[] SumZero(int n)
        {
            int[] answer = new int[n];
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                answer[i] = i;
                sum += i;
            }
            answer[0] = -sum;

            return answer;
        }
    }
}
