using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/diameter-of-binary-tree/
    /// </summary>
    public class _543_二叉树的直径
    {
        private int maxLen = 0;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            Height(root);
            return maxLen;
        }

        private int Height(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = Height(root.left);
            int rightHeight = Height(root.right);
            maxLen = Math.Max(maxLen, leftHeight + rightHeight);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
