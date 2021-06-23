using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/minimum-absolute-difference-in-bst/
    /// </summary>
    public class _530_二叉搜索树的最小绝对差
    {
        private int minDiff = int.MaxValue;
        private int preVal = -1;

        public int GetMinimumDifference(TreeNode root)
        {
            Inorder(root);
            return minDiff;
        }

        private void Inorder(TreeNode root)
        {
            if (root == null)
                return;

            Inorder(root.left);
            if (preVal >= 0)
                minDiff = Math.Min(minDiff, Math.Abs(preVal - root.val));
            preVal = root.val;
            Inorder(root.right);
        }
    }
}
