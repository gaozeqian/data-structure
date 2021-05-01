using System.Collections.Generic;
using System.Linq;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/missing-number/
     */
    public class _268_丢失的数字
    {
        public int MissingNumber(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            var sum = Enumerable
                .Range(0, nums.Length + 1)
                .Sum();

            foreach (var num in nums)
                sum -= num;

            return sum;
        }
    }
}