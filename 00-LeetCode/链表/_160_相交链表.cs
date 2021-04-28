using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00_LeetCode.链表
{
    /**
     * https://leetcode-cn.com/problems/intersection-of-two-linked-lists/
     */
    public class _160_相交链表
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            ListNode nodeA = headA, nodeB = headB;
            while(nodeA != nodeB)
            {
                if(nodeA != null)
                {
                    nodeA = nodeA.next;
                }
                else
                {
                    nodeA = headB;
                }

                if(nodeB != null)
                {
                    nodeB = nodeB.next;
                }
                else
                {
                    nodeB = headA;
                }
            }

            return nodeA;
        }
    }
}
