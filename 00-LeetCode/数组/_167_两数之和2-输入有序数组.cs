using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/two-sum-ii-input-array-is-sorted/
     */
    public class _167_两数之和2_输入有序数组
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] twoSum = new int[2];

            for(int i = 0, j = i + 1; j < numbers.Length;)
            {
                if(numbers[i] + numbers[j] < target)
                {
                    if(++j == numbers.Length)
                    {
                        j = ++i + 1;
                    }
                }
                else if(numbers[i] + numbers[j] > target)
                {
                    j = ++i + 1;
                }
                else
                {
                    twoSum[0] = ++i;
                    twoSum[1] = ++j;

                    break;
                }
            }

            return twoSum;
        }
    }
}
