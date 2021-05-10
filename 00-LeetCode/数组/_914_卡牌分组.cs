using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/x-of-a-kind-in-a-deck-of-cards/
    /// </summary>
    public class _914_卡牌分组
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            if (deck.Length == 1)
                return false;

            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int num in deck)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);
            }

            if (dic.Count == 1)
                return true;

            int gcd = -1;
            foreach (var item in dic)
            {
                if (gcd == -1)
                    gcd = item.Value;
                else
                    gcd = GCD(gcd, item.Value);
            }

            return gcd >= 2;
        }

        private int GCD(int num1, int num2)
        {
            return num1 == 0 ? num2 : GCD(num2 % num1, num1);
        }
    }
}
