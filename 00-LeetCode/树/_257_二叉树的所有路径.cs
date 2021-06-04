using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/binary-tree-paths/
    /// </summary>
    public class _257_二叉树的所有路径
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();
            ConstructPaths(root, "", paths);
            return paths;
        }

        private void ConstructPaths(TreeNode root, string path, List<string> paths)
        {
            if (root == null)
                return;

            path += root.val;
            if (root.left == null && root.right == null)
            {
                paths.Add(path);
            }
            else
            {
                path += "->";
                ConstructPaths(root.left, path, paths);
                ConstructPaths(root.right, path, paths);
            }
        }
    }
}
