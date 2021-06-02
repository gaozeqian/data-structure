using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/convert-sorted-array-to-binary-search-tree/
    /// </summary>
    public class _108_将有序数组转换为二叉搜索树
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return AddNode(nums, 0, nums.Length - 1);
        }

        private TreeNode AddNode(int[] nums, int left, int right)
        {
            if (left > right)
                return null;

            int mid = (left + right) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = AddNode(nums, left, mid - 1);
            root.right = AddNode(nums, mid + 1, right);
            return root;
        }
    }
}
