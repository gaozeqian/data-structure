using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/available-captures-for-rook/
    /// </summary>
    public class _999_可以被一步捕获的棋子数
    {
        public int NumRookCaptures(char[][] board)
        {
            int x = -1, y = -1;
            for(int r = 0; r < board.Length; r++)
            {
                if (x != -1)
                    break;

                for(int c = 0; c < board[0].Length; c++)
                {
                    if(board[r][c] == 'R')
                    {
                        x = c;
                        y = r;
                        break;
                    }
                }
            }

            int p = 0;
            for(int i = x; i >= 0; i--)
            {
                if (board[y][i] == 'p')
                {
                    p++;
                    break;
                }
                else if (board[y][i] == 'B')
                    break;
            }

            for (int i = x; i < board[0].Length; i++)
            {
                if (board[y][i] == 'p')
                {
                    p++;
                    break;
                }
                else if (board[y][i] == 'B')
                    break;
            }

            for (int i = y; i >= 0; i--)
            {
                if (board[i][x] == 'p')
                {
                    p++;
                    break;
                }
                else if (board[i][x] == 'B')
                    break;
            }

            for (int i = y; i < board.Length; i++)
            {
                if (board[i][x] == 'p')
                {
                    p++;
                    break;
                }
                else if (board[i][x] == 'B')
                    break;
            }

            return p;
        }
    }
}
