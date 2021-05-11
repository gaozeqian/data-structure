using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/squares-of-a-sorted-array/
    /// </summary>
    public class _977_有序数组的平方
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] sqNums = new int[nums.Length];

            if(nums[0] >= 0)
            {
                for (int i = 0; i < sqNums.Length; i++)
                    sqNums[i] = (int)Math.Pow(nums[i], 2);
            }
            else if(nums[nums.Length - 1] <= 0)
            {
                for (int i = 0; i < sqNums.Length; i++)
                    sqNums[i] = (int)Math.Pow(nums[nums.Length - 1 - i], 2);
            }
            else
            {
                int minIndex = 0, minValue = int.MaxValue, absValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    absValue = Math.Abs(nums[i]);
                    if (absValue < minValue)
                    {
                        minValue = absValue;
                        minIndex = i;
                    }
                    else if (absValue > minValue)
                        break;
                }

                int left = minIndex - 1, right = minIndex + 1;
                int leftValue, rightValue;
                sqNums[0] = (int)Math.Pow(nums[minIndex], 2);
                minIndex = 1;
                while (left >= 0 || right < nums.Length)
                {
                    leftValue = left >= 0 ? Math.Abs(nums[left]) : int.MaxValue;
                    rightValue = right < nums.Length ? Math.Abs(nums[right]) : int.MaxValue;
                    if (leftValue < rightValue)
                    {
                        sqNums[minIndex++] = (int)Math.Pow(leftValue, 2);
                        left--;
                    }
                    else
                    {
                        sqNums[minIndex++] = (int)Math.Pow(rightValue, 2);
                        right++;
                    }
                }
            }

            return sqNums;
        }
    }
}
