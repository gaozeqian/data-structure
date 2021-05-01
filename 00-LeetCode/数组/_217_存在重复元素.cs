using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/contains-duplicate/
     */
    public class _217_存在重复元素
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                    return true;
                else
                    dic.Add(num, 1);
            }

            return false;
        }
    }
}
