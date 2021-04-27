using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.链表
{
    /**
     * https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list/
     */
    public class _83_删除排序链表中的重复元素
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode node = head, next = node.next;

            while(next != null)
            {
                if(node.val == next.val)
                    node.next = next.next;
                else
                    node = next;

                next = next.next;
            }

            return head;
        }
    }
}
