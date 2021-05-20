using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/count-good-triplets/
    /// </summary>
    public class _1534_统计好三元组
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int answer = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    for(int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            answer++;
                    }
                }
            }

            return answer;
        }
    }
}
