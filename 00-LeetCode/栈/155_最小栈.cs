using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /*
     * https://leetcode-cn.com/problems/min-stack/
     */
    public class MinStack
    {
        private List<int> stack;
        private List<int> min;

        /** initialize your data structure here. */
        public MinStack()
        {
            stack = new List<int>();
            min = new List<int>();
        }

        public void Push(int val)
        {
            stack.Add(val);

            if (stack.Count == 1)
                min.Add(0);
            else if (val < stack[min[min.Count - 1]])
                min.Add(stack.Count - 1);
        }

        public void Pop()
        {
            if (stack.Count == 0)
                return;

            if (min[min.Count - 1] == stack.Count - 1)
                min.RemoveAt(min.Count - 1);

            stack.RemoveAt(stack.Count - 1);
        }

        public int Top()
        {
            return stack[stack.Count - 1];
        }

        public int GetMin()
        {
            return stack[min[min.Count - 1]];
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
