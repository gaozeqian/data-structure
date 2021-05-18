using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/check-if-n-and-its-double-exist/
    /// </summary>
    public class _1346_检查整数及其两倍数是否存在
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            HashSet<int> doubleSet = new HashSet<int>();
            foreach(int num in arr)
            {
                if (set.Contains(num << 1) || doubleSet.Contains(num))
                    return true;
                else
                {
                    set.Add(num);
                    doubleSet.Add(num << 1);
                }
            }

            return false;
        }
    }
}
