using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.链表
{
    /**
     * https://leetcode-cn.com/problems/palindrome-linked-list/
     */
    public class _234_回文链表
    {
        public bool IsPalindrome(ListNode head)
        {
            var node = head;
            var reverse = new Stack<int>();

            while(node != null)
            {
                reverse.Push(node.val);
                node = node.next;
            }

            while(head != null)
            {
                if (head.val != reverse.Pop())
                    return false;

                head = head.next;
            }

            return true;
        }
    }
}
