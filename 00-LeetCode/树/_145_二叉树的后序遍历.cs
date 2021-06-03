using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/binary-tree-postorder-traversal/
    /// </summary>
    public class _145_二叉树的后序遍历
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> val = new List<int>();
            Postorder(root, val);
            return val;
        }

        private void Postorder(TreeNode root, List<int> val)
        {
            if (root == null)
                return;

            Postorder(root.left, val);
            Postorder(root.right, val);
            val.Add(root.val);
        }
    }
}
