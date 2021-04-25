using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /**
     * https://leetcode-cn.com/problems/implement-stack-using-queues/
     */
    public class _225_用队列实现栈
    {
        private Queue<int> queue1;
        private Queue<int> queue2;

        /** Initialize your data structure here. */
        public _225_用队列实现栈()
        {
            queue1 = new Queue<int>();
            queue2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            if(queue1.Count == 0)
            {
                queue1.Enqueue(x);

                while (queue2.Count > 0)
                    queue1.Enqueue(queue2.Dequeue());
            }
            else
            {
                queue2.Enqueue(x);

                while (queue1.Count > 0)
                    queue2.Enqueue(queue1.Dequeue());
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            if (queue1.Count > 0)
                return queue1.Dequeue();
            else
                return queue2.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            if (queue1.Count > 0)
                return queue1.Peek();
            else
                return queue2.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return queue1.Count == 0 && queue2.Count == 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
