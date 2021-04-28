﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.链表
{
    /**
     * https://leetcode-cn.com/problems/middle-of-the-linked-list/
     */
    public class _876_链表的中间结点
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head, fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
