using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/check-array-formation-through-concatenation/
    /// </summary>
    public class _1640_能否连接形成数组
    {
        public bool CanFormArray(int[] arr, int[][] pieces)
        {
            for(int r = 0; r < pieces.Length; r++)
            {
                int index = 0;
                for (int c = 0; c < pieces[r].Length; c++)
                {
                    if(c == 0)
                    {
                        for (; index <= arr.Length - pieces[r].Length; index++)
                        {
                            if (pieces[r][0] == arr[index])
                                break;
                        }

                        if (index + pieces[r].Length > arr.Length)
                            return false;
                    }
                    else
                    {
                        if (pieces[r][c] != arr[++index])
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
