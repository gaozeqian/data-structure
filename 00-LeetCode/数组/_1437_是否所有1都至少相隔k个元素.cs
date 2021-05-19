using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/check-if-all-1s-are-at-least-length-k-places-away/
    /// </summary>
    public class _1437_是否所有1都至少相隔k个元素
    {
        public bool KLengthApart(int[] nums, int k)
        {
            int places = -1;
            foreach(int num in nums)
            {
                if(num == 1)
                {
                    if (places >= 0 && places < k)
                        return false;

                    places = 0;
                }
                else if(places >= 0)
                {
                    places++;
                }
            }

            return true;
        }
    }
}
