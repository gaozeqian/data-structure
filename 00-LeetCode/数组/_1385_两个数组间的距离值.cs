using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-the-distance-value-between-two-arrays/
    /// </summary>
    public class _1385_两个数组间的距离值
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int answer = 0;
            foreach(int num1 in arr1)
            {
                bool gt = true;
                foreach(int num2 in arr2)
                {
                    if(Math.Abs(num1 - num2) <= d)
                    {
                        gt = false;
                        break;
                    }
                }

                if (gt)
                    answer++;
            }

            return answer;
        }
    }
}
