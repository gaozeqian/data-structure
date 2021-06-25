using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.树
{
    /// <summary>
    /// https://leetcode-cn.com/problems/average-of-levels-in-binary-tree/
    /// </summary>
    public class _637_二叉树的层平均值
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            Queue<TreeNode> swap = null;

            List<double> answer = new List<double>();
            double sum = 0;
            int count = 0;

            queue1.Enqueue(root);

            while(queue1.Count > 0)
            {
                TreeNode node = queue1.Dequeue();
                sum += node.val;
                count++;

                if (node.left != null)
                    queue2.Enqueue(node.left);

                if (node.right != null)
                    queue2.Enqueue(node.right);

                if(queue1.Count == 0)
                {
                    answer.Add(sum / count);
                    sum = 0;
                    count = 0;

                    swap = queue1;
                    queue1 = queue2;
                    queue2 = swap;
                }
            }

            return answer;
        }
    }
}
