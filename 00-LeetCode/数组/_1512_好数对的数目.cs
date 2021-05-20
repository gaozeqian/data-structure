using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/number-of-good-pairs/
    /// </summary>
    public class _1512_好数对的数目
    {
        public int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);
            }

            int sum = 0;
            foreach (var item in dic)
                sum += CountPairs(item.Value);

            return sum;
        }

        private int CountPairs(int n)
        {
            int pairs = 0;
            while (--n > 0)
                pairs += n;
            return pairs;
        }
    }
}
