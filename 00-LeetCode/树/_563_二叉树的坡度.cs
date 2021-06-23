using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/binary-tree-tilt/
    /// </summary>
    public class _563_二叉树的坡度
    {
        private int tilt = 0;

        public int FindTilt(TreeNode root)
        {
            Preorder(root);
            return tilt;
        }

        private int Preorder(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = Preorder(root.left);
            int right = Preorder(root.right);
            tilt += Math.Abs(left - right);
            return left + right + root.val;
        }
    }
}
