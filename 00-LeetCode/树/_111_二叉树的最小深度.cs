using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/minimum-depth-of-binary-tree/
    /// </summary>
    public class _111_二叉树的最小深度
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            int minDepth = int.MaxValue;
            if (root.left != null)
                minDepth = Math.Min(MinDepth(root.left), minDepth);

            if (root.right != null)
                minDepth = Math.Min(MinDepth(root.right), minDepth);

            return minDepth + 1;
        }
    }
}
