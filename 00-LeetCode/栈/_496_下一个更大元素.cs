using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /**
     * https://leetcode-cn.com/problems/next-greater-element-i/
     */
    public class _496_下一个更大元素
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var max = new int[nums1.Length];

            for(int i = 0; i < nums1.Length; i++)
            {
                for(int j = Array.IndexOf(nums2, nums1[i]) + 1; j < nums2.Length; j++)
                {
                    if(nums1[i] < nums2[j])
                    {
                        max[i] = nums2[j];
                        break;
                    }
                }

                if (max[i] == 0)
                    max[i] = -1;
            }

            return max;
        }
    }
}
