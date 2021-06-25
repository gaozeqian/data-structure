using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/n-ary-tree-postorder-traversal/
    /// </summary>
    public class _590_N叉树的后序遍历
    {
        private List<int> nodes = new List<int>();

        public IList<int> Postorder(Node root)
        {
            if (root == null)
                return nodes;

            foreach (Node node in root.children)
                Postorder(node);
            nodes.Add(root.val);

            return nodes;
        }
    }
}
