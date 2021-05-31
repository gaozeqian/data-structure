using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/binary-tree-inorder-traversal/
    /// </summary>
    public class _94_二叉树的中序遍历
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            Inorder(root, list);
            return list;
        }

        private void Inorder(TreeNode node, List<int> list)
        {
            if (node == null)
                return;

            Inorder(node.left, list);
            list.Add(node.val);
            Inorder(node.right, list);
        }

        private IList<int> Inorder(TreeNode node)
        {
            List<int> list = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while(node != null || stack.Count > 0)
            {
                while(node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }

                node = stack.Pop();
                list.Add(node.val);
                node = node.right;
            }

            return list;
        }
    }
}
