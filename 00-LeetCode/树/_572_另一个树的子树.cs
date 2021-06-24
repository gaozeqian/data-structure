using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/subtree-of-another-tree/
    /// </summary>
    public class _572_另一个树的子树
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            return Dfs(root, subRoot);
        }

        private bool Dfs(TreeNode root, TreeNode subRoot)
        {
            if (root == null)
                return false;

            return Check(root, subRoot) || Dfs(root.left, subRoot) || Dfs(root.right, subRoot);
        }

        private bool Check(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null)
                return true;

            if (root == null || subRoot == null || root.val != subRoot.val)
                return false;

            return Check(root.left, subRoot.left) && Check(root.right, subRoot.right);
        }
    }
}
