using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/merge-sorted-array/
     */
    public class _88_合并两个有序数组
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
                return;

            int index1 = 0, index2 = 0;
            while(index2 < n && index1 < m + index2)
            {
                if(nums2[index2] < nums1[index1])
                {
                    for(int i = m + index2; i > index1; i--)
                    {
                        nums1[i] = nums1[i - 1];
                    }
                    nums1[index1] = nums2[index2++];
                }

                index1++;
            }

            while(index2 < n)
            {
                nums1[index1++] = nums2[index2++];
            }
        }
    }
}
