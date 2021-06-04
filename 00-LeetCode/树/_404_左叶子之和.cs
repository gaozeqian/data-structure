using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/sum-of-left-leaves/
    /// </summary>
    public class _404_左叶子之和
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
                return 0;

            int ans = 0;
            if (root.left != null)
                ans += IsLeafNode(root.left) ? root.left.val : SumOfLeftLeaves(root.left);

            if (root.right != null && !IsLeafNode(root.right))
                ans += SumOfLeftLeaves(root.right);

            return ans;
        }

        private bool IsLeafNode(TreeNode node)
        {
            return node.left == null && node.right == null;
        }
    }
}
