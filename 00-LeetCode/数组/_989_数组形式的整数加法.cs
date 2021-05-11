using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/add-to-array-form-of-integer/
    /// </summary>
    public class _989_数组形式的整数加法
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            for(int i = num.Length - 1; i >= 0; i--)
            {
                num[i] += k;
                if (num[i] <= 9)
                {
                    k = 0;
                    break;
                }

                k = num[i] / 10;
                num[i] %= 10;
            }

            if (k == 0)
                return num;
            else
            {
                List<int> list = new List<int>();
                while(k != 0)
                {
                    list.Add(k % 10);
                    k /= 10;
                }
                list.Reverse();
                list.AddRange(num);
                return list;
            }
        }
    }
}
