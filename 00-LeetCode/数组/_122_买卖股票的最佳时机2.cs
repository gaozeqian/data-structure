using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-ii/
     */
    public class _122_买卖股票的最佳时机2
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0,
                minPrice = int.MaxValue;

            for(int i = 0; i < prices.Length - 1; i++)
            {
                if(prices[i] < prices[i + 1])
                {
                    if(prices[i] < minPrice)
                    {
                        minPrice = prices[i];
                    }
                }
                else
                {
                    if(prices[i] - minPrice > 0)
                    {
                        maxProfit += prices[i] - minPrice;
                        minPrice = int.MaxValue;
                    }
                }
            }

            if(minPrice < int.MaxValue)
            {
                maxProfit += prices[prices.Length - 1] - minPrice;
            }

            return maxProfit;
        }
    }
}
