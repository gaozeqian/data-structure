using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/make-two-arrays-equal-by-reversing-sub-arrays/
    /// </summary>
    public class _1460_通过翻转子数组使两个数组相等
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            int minTarget = int.MaxValue;
            int maxTarget = int.MinValue;
            foreach(int num in target)
            {
                if (num < minTarget)
                    minTarget = num;

                if (num > maxTarget)
                    maxTarget = num;
            }

            int minArr = int.MaxValue;
            int maxArr = int.MinValue;
            foreach (int num in arr)
            {
                if (num < minArr)
                    minArr = num;

                if (num > maxArr)
                    maxArr = num;
            }

            if (minTarget != minArr || maxTarget != maxArr)
                return false;

            int[] countTarget = new int[maxTarget - minTarget + 1];
            for (int i = 0; i < target.Length; i++)
                countTarget[target[i] - minTarget]++;

            int[] countArr = new int[maxArr - minArr + 1];
            for (int i = 0; i < arr.Length; i++)
                countArr[arr[i] - minArr]++;

            for(int i = 0; i < countArr.Length; i++)
            {
                if (countArr[i] != countTarget[i])
                    return false;
            }

            return true;
        }
    }
}
