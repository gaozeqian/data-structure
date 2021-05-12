using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/height-checker/
    /// </summary>
    public class _1051_高度检查器
    {
        public int HeightChecker(int[] heights)
        {
            if (heights.Length == 1)
                return 0;

            int[] original = new int[heights.Length];
            Array.Copy(heights, original, heights.Length);
            Array.Sort(heights);

            int counter = 0;
            for(int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != original[i])
                    counter++;
            }

            return counter++;
        }
    }
}
