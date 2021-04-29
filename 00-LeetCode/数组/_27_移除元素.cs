using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/remove-element/
     */
    public class _27_移除元素
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;

            int length = nums.Length;
            
            for(int i = 0; i < length;)
            {
                if(val == nums[i])
                {
                    length--;

                    for(int j = i; j < length;)
                    {
                        nums[j] = nums[++j];
                    }

                    continue;
                }

                i++;
            }

            return length;
        }
    }
}
