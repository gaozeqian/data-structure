using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/count-largest-group/
    /// </summary>
    public class _1399_统计最大组的数目
    {
        public int CountLargestGroup(int n)
        {
            int tmp = n;
            int maxValue = 0;
            while(tmp != 0)
            {
                maxValue += 9;
                tmp /= 10;
            }

            int[] count = new int[maxValue + 1];
            for(int i = 1; i <= n; i++)
            {
                int val = 0;
                tmp = i;
                while(tmp != 0)
                {
                    val += tmp % 10;
                    tmp /= 10;
                }
                count[val]++;
            }

            maxValue = 1;
            int groups = 0;
            foreach(int num in count)
            {
                if(num > maxValue)
                {
                    maxValue = num;
                    groups = 1;
                }
                else if(num == maxValue)
                {
                    groups++;
                }
            }

            return groups;
        }
    }
}
