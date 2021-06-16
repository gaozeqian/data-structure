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
        private List<int> ans = new List<int>();
        private int num, count, maxCount;

        public int[] FindMode(TreeNode root)
        {
            dfs(root);
            return ans.ToArray();
        }

        private void dfs(TreeNode root)
        {
            if (root == null)
                return;

            dfs(root.left);
            update(root.val);
            dfs(root.right);
        }

        private void update(int val)
        {
            if(val == num)
            {
                count++;
            }
            else
            {
                num = val;
                count = 1;
            }

            if(count == maxCount)
            {
                ans.Add(num);
            }
            else if(count > maxCount)
            {
                ans.Clear();
                ans.Add(num);
                maxCount = count;
            }
        }
    }
}
