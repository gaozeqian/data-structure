using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/partition-array-into-three-parts-with-equal-sum/
    /// </summary>
    public class _1013_将数组分成和相等的三个部分
    {
        public bool CanThreePartsEqualSum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
                sum += num;

            if (sum % 3 != 0)
                return false;

            sum /= 3;
            int left = arr[0], right = arr[arr.Length - 1];
            int i = 0, j = arr.Length - 1;
            do
            {
                if (left == sum && right == sum)
                    break;

                if (left != sum)
                    left += arr[++i];

                if (right != sum)
                    right += arr[--j];
            } while (i + 1 < j);

            if(i + 1 < j)
            {
                sum = 0;
                for (int k = i + 1; k < j; k++)
                    sum += arr[k];

                if (sum == left)
                    return true;
            }

            return false;
        }
    }
}
