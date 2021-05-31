using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/symmetric-tree/
    /// </summary>
    public class _101_对称二叉树
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            else
                return IsSameTree(root.left, root.right);
        }

        private bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if (p == null || q == null)
                return false;
            else if (p.val != q.val)
                return false;
            else
                return IsSameTree(p.left, q.right) && IsSameTree(p.right, q.left);
        }
    }
}
