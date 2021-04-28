using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.链表
{
    /**
     * https://leetcode-cn.com/problems/convert-binary-number-in-a-linked-list-to-integer/
     */
    public class _1290_二进制链表转整数
    {
        public int GetDecimalValue(ListNode head)
        {
            StringBuilder sb = new StringBuilder();

            while(head != null)
            {
                sb.Append(head.val);
                head = head.next;
            }

            return Convert.ToInt32(sb.ToString(), 2);
        }
    }
}
