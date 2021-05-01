using System.Collections.Generic;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/summary-ranges/
     */
    public class _228_汇总区间
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            if (nums.Length == 0)
                return new List<string>();

            int start = 0;
            List<string> range = new List<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    start = nums[i];
                else if (nums[i] == nums[i - 1] || nums[i] == nums[i - 1] + 1)
                    continue;
                else
                {
                    if (start == nums[i - 1])
                        range.Add(start.ToString());
                    else
                        range.Add(string.Format("{0}->{1}", start, nums[i - 1]));

                    start = nums[i];
                }
            }

            if (start == nums[nums.Length - 1])
                range.Add(start.ToString());
            else
                range.Add(string.Format("{0}->{1}", start, nums[nums.Length - 1]));

            return range;
        }
    }
}