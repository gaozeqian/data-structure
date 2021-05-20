using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/most-visited-sector-in-a-circular-track/
    /// </summary>
    public class _1560_圆形赛道上经过次数最多的扇区
    {
        public IList<int> MostVisited(int n, int[] rounds)
        {
            int[] count = new int[n + 1];
            int start = rounds[0];
            count[start]++;
            for(int i = 1; i < rounds.Length; i++)
            {
                while(start != rounds[i])
                {
                    start = (++start > n) ? 1 : start;
                    count[start]++;
                }
            }

            int max = 0;
            foreach(int num in count)
            {
                if (num > max)
                    max = num;
            }

            List<int> ans = new List<int>();
            for(int i = 1; i <= n; i++)
            {
                if (count[i] == max)
                    ans.Add(i);
            }

            return ans;
        }
    }
}
