using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.链表
{
    /**
     * https://leetcode-cn.com/problems/remove-linked-list-elements/
     */
    public class _203_移除链表元素
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode node = head, prev = null;

            while (node != null)
            {
                if (val == head.val)
                {
                    node = head = head.next;
                }
                else
                {
                    if (val == node.val)
                    {
                        prev.next = node.next;
                    }
                    else
                    {
                        prev = node;
                    }

                    node = node.next;
                }
            }

            return head;
        }
    }
}
