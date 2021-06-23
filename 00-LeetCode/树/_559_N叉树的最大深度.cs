using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/maximum-depth-of-n-ary-tree/
    /// </summary>
    public class _559_N叉树的最大深度
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
                return 0;

            int maxDepth = 0;
            foreach (Node node in root.children)
            {
                int tempDepth = MaxDepth(node);
                if (tempDepth > maxDepth)
                    maxDepth = tempDepth;
            }
            return maxDepth + 1;
        }
    }
}
