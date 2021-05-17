using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-winner-on-a-tic-tac-toe-game/
    /// </summary>
    public class _1275_找出井字棋的获胜者
    {
        public string Tictactoe(int[][] moves)
        {
            var wins = new List<List<int>>
            {
                new List<int> {0, 1, 2},
                new List<int> {3, 4, 5},
                new List<int> {6, 7, 8},
                new List<int> {0, 3, 6},
                new List<int> {1, 4, 7},
                new List<int> {2, 5, 8},
                new List<int> {0, 4, 8},
                new List<int> {2, 4, 6}
            };

            List<int> A = new List<int>();
            List<int> B = new List<int>();
            for(int i = 0; i < moves.Length; i++)
            {
                int pos = moves[i][0] * 3 + moves[i][1];
                if((i & 1) == 0)
                {
                    A.Add(pos);
                    if (CheckWin(A, wins))
                        return "A";
                }
                else
                {
                    B.Add(pos);
                    if (CheckWin(B, wins))
                        return "B";
                }
            }

            if (moves.Length < 9)
                return "Pending";
            else
                return "Draw";
        }

        private bool CheckWin(List<int> player, List<List<int>> wins)
        {
            if (player.Count < 3)
                return false;

            for(int i = 0; i < wins.Count; i++)
            {
                if (player.Intersect(wins[i]).Count() == 3)
                    return true;
            }

            return false;
        }
    }
}
