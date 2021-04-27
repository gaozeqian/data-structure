using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.链表
{
    /**
     * https://leetcode-cn.com/problems/linked-list-cycle/
     */
    public class _141_环形链表
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;

            ListNode slow = head, fast = head.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    return true;
            }

            return false;
        }
    }
}
