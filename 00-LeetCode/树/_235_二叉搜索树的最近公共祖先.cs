using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
    /// </summary>
    public class _235_二叉搜索树的最近公共祖先
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while(true)
            {
                if (p.val < root.val && q.val < root.val)
                    root = root.left;
                else if (p.val > root.val && q.val > root.val)
                    root = root.right;
                else
                    break;
            }

            return root;
        }
    }
}
