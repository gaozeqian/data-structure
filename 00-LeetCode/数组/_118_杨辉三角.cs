using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/pascals-triangle/
     */
    public class _118_杨辉三角
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var rows = new List<IList<int>>();

            for(int i = 0; i < numRows; i++)
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

            return rows;
        }
    }
}
