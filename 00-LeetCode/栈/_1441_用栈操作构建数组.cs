using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /**
     * https://leetcode-cn.com/problems/build-an-array-with-stack-operations/
     */
    public class _1441_用栈操作构建数组
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            var stack = new Stack<string>();
            int index = 0;

            for(int i = 1; i <= n; i++)
            {
                if (index == target.Length)
                    break;

                if (i == target[index])
                {
                    stack.Push("Push");
                    index++;
                }
                else
                {
                    stack.Push("Push");
                    stack.Push("Pop");
                }
            }

            var stackReverse = new Stack<string>();
            while (stack.Count > 0)
                stackReverse.Push(stack.Pop());

            var list = new List<string>();
            while (stackReverse.Count > 0)
                list.Add(stackReverse.Pop());

            return list;
        }
    }
}
