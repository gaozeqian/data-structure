using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/balanced-binary-tree/
    /// </summary>
    public class _110_平衡二叉树
    {
        public bool IsBalanced(TreeNode root)
        {
            return GetDepth(root) >= 0;
        }

        private int GetDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftDepth = GetDepth(root.left);
            int rightDept = GetDepth(root.right);
            if (leftDepth == -1 || rightDept == -1 || Math.Abs(leftDepth - rightDept) > 1)
                return -1;
            else
                return Math.Max(leftDepth, rightDept) + 1;
        }
    }
}
