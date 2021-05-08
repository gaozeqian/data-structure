using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/positions-of-large-groups/
    /// </summary>
    public class _830_较大分组的位置
    {
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            IList<IList<int>> groups = new List<IList<int>>();

            int start = 0, end = s.Length - 1;
            char value = ' ';
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] != value)
                {
                    end = i - 1;
                    if (end - start > 1)
                        groups.Add(new List<int> { start, end });

                    start = i;
                    value = s[i];
                }
            }

            end = end < start ? s.Length - 1 : end;
            if (end - start > 1)
                groups.Add(new List<int> { start, end });

            return groups;
        }
    }
}
