using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /**
     * https://leetcode-cn.com/problems/baseball-game/
     */
    public class _682_棒球比赛
    {
        public int CalPoints(string[] ops)
        {
            var stack = new Stack<int>();

            foreach(var option in ops)
            {
                if("+".Equals(option))
                {
                    int lastScore = stack.Pop();
                    int newScore = stack.Peek() + lastScore;
                    stack.Push(lastScore);
                    stack.Push(newScore);
                }
                else if("D".Equals(option))
                {
                    stack.Push(2 * stack.Peek());
                }
                else if("C".Equals(option))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(int.Parse(option));
                }
            }

            int sum = 0;
            while (stack.Count > 0)
                sum += stack.Pop();

            return sum;
        }
    }
}
