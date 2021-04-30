using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/pascals-triangle-ii/
     */
    public class _119_杨辉三角2
    {
        public IList<int> GetRow(int rowIndex)
        {
            var rows = new List<List<int>>();

            for (int i = 0; i <= rowIndex; i++)
            {
                var row = new List<int>();

                if (i == 0)
                {
                    row.Add(1);
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                        {
                            row.Add(1);
                        }
                        else
                        {
                            row.Add(rows[i - 1][j - 1] + rows[i - 1][j]);
                        }
                    }
                }

                rows.Add(row);
            }

            return rows[rowIndex];
        }
    }
}
