using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/invert-binary-tree/
    /// </summary>
    public class _226_翻转二叉树
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);
            root.left = right;
            root.right = left;

            return root;
        }
    }
}
