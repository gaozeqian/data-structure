using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/minimum-cost-to-move-chips-to-the-same-position/
    /// </summary>
    public class _1217_玩筹码
    {
        public int MinCostToMoveChips(int[] position)
        {
            int[] chips = new int[2];
            foreach(int pos in position)
            {
                if ((pos & 1) == 0)
                    chips[0]++;
                else
                    chips[1]++;
            }

            return Math.Min(chips[0], chips[1]);
        }
    }
}
