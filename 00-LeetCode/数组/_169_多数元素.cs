using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/majority-element/
     */
    public class _169_多数元素
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach(var num in nums)
            {
                if(dic.ContainsKey(num))
                {
                    dic[num] += 1;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }

            return dic.OrderByDescending(d => d.Value).First().Key;
        }
    }
}
