using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    public class _104_二叉树的最大深度
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                int leftDepth = MaxDepth(root.left);
                int rightDepth = MaxDepth(root.right);
                return Math.Max(leftDepth, rightDepth) + 1;
            }
        }
    }
}
