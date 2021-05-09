using System.Collections.Generic;

namespace _00_LeetCode.堆
{
    /// <summary>
    /// https://leetcode-cn.com/problems/last-stone-weight/
    /// <summary>
    public class _1046_最后一块石头的重量
    {
        private readonly LinkedList<int> list = new LinkedList<int>();

        public int LastStoneWeight(int[] stones)
        {
            for (int i = 0; i < stones.Length; i++)
                Insert(stones[i]);

            int max1, max2;
            while (list.Count > 1)
            {
                max1 = list.Last.Value;
                list.RemoveLast();
                max2 = list.Last.Value;
                list.RemoveLast();

                int minus = max1 - max2;
                if (minus > 0)
                    Insert(minus);
            }

            if (list.Count > 0)
                return list.First.Value;
            else
                return 0;
        }

        private void Insert(int val)
        {
            if (list.Count == 0)
            {
                list.AddFirst(val);
                return;
            }

            var node = list.First;
            bool notAdded = true;
            while (node != null)
            {
                if (val <= node.Value)
                {
                    list.AddBefore(node, val);
                    notAdded = false;
                    break;
                }

                node = node.Next;
            }

            if (notAdded)
                list.AddLast(val);
        }
    }
}