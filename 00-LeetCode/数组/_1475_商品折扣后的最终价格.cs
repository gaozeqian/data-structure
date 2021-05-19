using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/final-prices-with-a-special-discount-in-a-shop/
    /// </summary>
    public class _1475_商品折扣后的最终价格
    {
        public int[] FinalPrices(int[] prices)
        {
            int[] answer = new int[prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                int tmp = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        tmp = prices[j];
                        break;
                    }
                }

                answer[i] = prices[i] - tmp;
            }

            return answer;
        }
    }
}
