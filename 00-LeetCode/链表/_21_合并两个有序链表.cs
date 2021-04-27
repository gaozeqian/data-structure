using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.链表
{
    /**
     * https://leetcode-cn.com/problems/merge-two-sorted-lists/
     */
    public class _21_合并两个有序链表
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode l3 = null, tail = null, tmp = null;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    tmp = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    tmp = new ListNode(l2.val);
                    l2 = l2.next;
                }

                if (l3 == null)
                    l3 = tail = tmp;
                else
                    tail = tail.next = tmp;
            }

            if (l3 == null)
            {
                l3 = l1 == null ? l2 : l1;
            }
            else
            {
                if (l1 != null)
                    tail.next = l1;
                else if (l2 != null)
                    tail.next = l2;
            }

            return l3;
        }
    }
}
