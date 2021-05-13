using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/number-of-equivalent-domino-pairs/
    /// </summary>
    public class _1128_等价多米诺骨牌对的数量
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            Dictionary<int[], int> dic = new Dictionary<int[], int>(new ArrayEqualityComparer());
            foreach(var domino in dominoes)
            {
                if (dic.ContainsKey(domino))
                    dic[domino]++;
                else
                    dic.Add(domino, 1);
            }

            int pairs = 0;
            foreach(var item in dic)
            {
                for (int i = 1; i < item.Value; i++)
                    pairs += i;
            }

            return pairs;
        }

        private class ArrayEqualityComparer : IEqualityComparer<int[]>
        {
            public bool Equals(int[] x, int[] y)
            {
                return (x[0] == y[0] && x[1] == y[1]) || (x[0] == y[1] && x[1] == y[0]);
            }

            public int GetHashCode(int[] obj)
            {
                return obj[0].GetHashCode() + obj[1].GetHashCode();
            }
        }
    }
}
