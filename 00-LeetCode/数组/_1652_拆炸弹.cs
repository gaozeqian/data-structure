using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/defuse-the-bomb/
    /// </summary>
    public class _1652_拆炸弹
    {
        public int[] Decrypt(int[] code, int k)
        {
            int[] ans = new int[code.Length];

            if(k > 0)
            {
                for(int i = 0; i < ans.Length; i++)
                {
                    for(int j = 1; j <= k; j++)
                    {
                        ans[i] += code[i + j >= code.Length ? i + j - code.Length : i + j];
                    }
                }
            }
            else if(k < 0)
            {
                for(int i = 0; i < ans.Length; i++)
                {
                    for(int j = -1; j >= k; j--)
                    {
                        ans[i] += code[i + j <= -1 ? i + j + code.Length : i + j];
                    }
                }
            }

            return ans;
        }
    }
}
