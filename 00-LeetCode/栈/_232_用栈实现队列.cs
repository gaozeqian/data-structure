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
        private readonly Stack<int> stack1;
        private readonly Stack<int> stack2;

        /** Initialize your data structure here. */
        public _232_用栈实现队列()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if(stack1.Count > 1)
            {
                while (stack1.Count > 0)
                    stack2.Push(stack1.Pop());

                stack2.Push(x);
            }
            else if(stack2.Count > 1)
            {
                while (stack2.Count > 0)
                    stack1.Push(stack2.Pop());

                stack1.Push(x);
            }
            else
            {
                if (stack1.Count == 1)
                    stack1.Push(x);
                else
                    stack2.Push(x);
            }

            if(stack1.Count > 1)
            {
                while (stack1.Count > 0)
                    stack2.Push(stack1.Pop());
            }
            else if(stack2.Count > 1)
            {
                while (stack2.Count > 0)
                    stack1.Push(stack2.Pop());
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (stack1.Count > 0)
                return stack1.Pop();
            else
                return stack2.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (stack1.Count > 0)
                return stack1.Peek();
            else
                return stack2.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stack1.Count == 0 && stack2.Count == 0;
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
