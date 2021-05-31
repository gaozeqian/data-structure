using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/same-tree/
    /// </summary>
    public class _100_相同的树
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if (p == null || q == null)
                return false;
            else if (p.val != q.val)
                return false;
            else
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
