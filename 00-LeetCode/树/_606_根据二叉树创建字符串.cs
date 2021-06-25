using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/construct-string-from-binary-tree/
    /// </summary>
    public class _606_根据二叉树创建字符串
    {
        private StringBuilder sb = new StringBuilder();

        public string Tree2str(TreeNode root)
        {
            Preorder(root);
            return sb.ToString();
        }

        private void Preorder(TreeNode root)
        {
            if (root == null)
                return;

            sb.Append(root.val);

            if (root.left != null || root.right != null)
            {
                sb.Append('(');
                Preorder(root.left);
                sb.Append(')');
            }

            if (root.right != null)
            {
                sb.Append('(');
                Preorder(root.right);
                sb.Append(')');
            }
        }
    }
}
