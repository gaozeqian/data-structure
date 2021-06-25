using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/n-ary-tree-preorder-traversal/
    /// </summary>
    public class _589_N叉树的前序遍历
    {
        private List<int> nodes = new List<int>();

        public IList<int> Preorder(Node root)
        {
            if (root == null)
                return nodes;

            nodes.Add(root.val);
            foreach (Node node in root.children)
                Preorder(node);

            return nodes;
        }
    }
}
