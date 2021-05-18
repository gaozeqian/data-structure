using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/decompress-run-length-encoded-list/
    /// </summary>
    public class _1313_解压缩编码列表
    {
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < nums.Length; i += 2)
            {
                while(nums[i] > 0)
                {
                    list.Add(nums[i + 1]);
                    nums[i]--;
                }
            }

            return list.ToArray();
        }
    }
}
