using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/minimum-absolute-difference/
    /// </summary>
    public class _1200_最小绝对差
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            var answer = new List<IList<int>>();
            Array.Sort(arr);

            int minMinus = int.MaxValue;
            for(int i = 1; i < arr.Length; i++)
            {
                int tmp = arr[i] - arr[i - 1];
                if(tmp < minMinus)
                {
                    minMinus = tmp;
                    answer.Clear();
                    answer.Add(new List<int> { arr[i - 1], arr[i] });
                }
                else if(tmp == minMinus)
                {
                    answer.Add(new List<int> { arr[i - 1], arr[i] });
                }
            }

            return answer;
        }
    }
}
