using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-mode-in-binary-search-tree/
    /// </summary>
    public class _501_二叉搜索树中的众数
    {
        public int[] FindMode(TreeNode root)
        {
            HashSet<int> modes = new HashSet<int>();
            FindMode(root, modes);
            int[] ans = new int[modes.Count];
            int index = 0;
            foreach (int mode in modes)
                ans[index++] = mode;
            return ans;
        }

        private void FindMode(TreeNode root, HashSet<int> modes)
        {
            if (root == null)
                return;

            if (IsModes(root))
                modes.Add(root.val);

            FindMode(root.left, modes);
            FindMode(root.right, modes);
        }

        private bool IsModes(TreeNode node)
        {
            return node.val == node.left?.val || node.val == node.right?.val;
        }
    }
}
