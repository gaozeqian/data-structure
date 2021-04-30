using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/
     */
    public class _121_买卖股票的最佳时机
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue, 
                maxProfit = 0;

            foreach(var price in prices)
            {
                if(price < minPrice)
                {
                    minPrice = price;
                }
                else if(price - minPrice > maxProfit)
                {
                    maxProfit = price - minPrice;
                }
            }

            return maxProfit;
        }
    }
}
