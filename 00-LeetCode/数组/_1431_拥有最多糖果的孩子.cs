using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/kids-with-the-greatest-number-of-candies/
    /// </summary>
    public class _1431_拥有最多糖果的孩子
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int maxValue = int.MinValue;
            foreach(int num in candies)
            {
                if (num > maxValue)
                    maxValue = num;
            }

            bool[] answer = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
                answer[i] = maxValue <= candies[i] + extraCandies;

            return answer;
        }
    }
}
