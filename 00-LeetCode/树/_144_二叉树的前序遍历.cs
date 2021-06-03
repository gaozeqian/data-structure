using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/
    /// </summary>
    public class _144_二叉树的前序遍历
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> val = new List<int>();
            Preorder(root, val);
            return val;
        }

        private void Preorder(TreeNode root, List<int> val)
        {
            if (root == null)
                return;

            val.Add(root.val);
            Preorder(root.left, val);
            Preorder(root.right, val);
        }
    }
}
