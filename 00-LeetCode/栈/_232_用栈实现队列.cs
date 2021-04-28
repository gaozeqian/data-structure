using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /**
     * https://leetcode-cn.com/problems/implement-queue-using-stacks/
     */
    public class _232_用栈实现队列
    {
        private readonly Stack<int> inStack;
        private readonly Stack<int> outStack;

        /** Initialize your data structure here. */
        public _232_用栈实现队列()
        {
            inStack = new Stack<int>();
            outStack = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            inStack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            CheckOutStack();
            return outStack.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            CheckOutStack();
            return outStack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return inStack.Count == 0 && outStack.Count == 0;
        }

        private void CheckOutStack()
        {
            if (outStack.Count == 0)
            {
                while (inStack.Count > 0)
                    outStack.Push(inStack.Pop());
            }
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
