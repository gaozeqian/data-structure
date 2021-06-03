using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/path-sum/
    /// </summary>
    public class _112_路径总和
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while(stack.Count > 0)
            {
                root = stack.Pop();
                if (root.left == null && root.right == null && root.val == targetSum)
                    return true;

                if(root.left != null)
                {
                    root.left.val += root.val;
                    stack.Push(root.left);
                }

                if(root.right != null)
                {
                    root.right.val += root.val;
                    stack.Push(root.right);
                }
            }

            return false;
        }
    }
}
