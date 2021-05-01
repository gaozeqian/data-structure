using System.Linq;
using System.Collections.Generic;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/third-maximum-number/
     */
    public class _414_第三大的数
    {
        public int ThirdMax(int[] nums)
        {
            List<int> maxes = new List<int>();

            foreach (var num in nums)
            {
                if (!maxes.Contains(num))
                {
                    if (maxes.Count < 3)
                    {
                        maxes.Add(num);
                    }
                    else
                    {
                        var min = maxes.Min();
                        if (num > min)
                        {
                            maxes[maxes.IndexOf(min)] = num;
                        }
                    }
                }
            }

            if (maxes.Count < 3)
                return maxes.Max();
            else
                return maxes.Min();
        }
    }
}