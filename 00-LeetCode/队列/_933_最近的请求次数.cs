using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.队列
{
    /// <summary>
    /// https://leetcode-cn.com/problems/number-of-recent-calls/
    /// </summary>
    public class _933_最近的请求次数
    {
        private readonly Queue<int> pings;

        public _933_最近的请求次数()
        {
            pings = new Queue<int>();
        }

        public int Ping(int t)
        {
            pings.Enqueue(t);

            while (t - pings.Peek() > 3000)
                pings.Dequeue();

            return pings.Count;
        }
    }

    /**
     * Your RecentCounter object will be instantiated and called as such:
     * RecentCounter obj = new RecentCounter();
     * int param_1 = obj.Ping(t);
     */
}
