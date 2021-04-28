using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.链表
{
    /**
     * https://leetcode-cn.com/problems/reverse-linked-list/
     */
    public class _206_反转链表
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode newHead = null;
            while (head != null)
            {
                var tmp = head.next;
                head.next = newHead;
                newHead = head;
                head = tmp;
            }

            return newHead;
        }
    }
}
