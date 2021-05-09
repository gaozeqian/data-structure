using System.Collections.Generic;

namespace _00_LeetCode.堆
{
    /// <summary>
    /// https://leetcode-cn.com/problems/kth-largest-element-in-a-stream/
    /// <summary>
    public class _703_数据流中的第K大元素
    {
        private readonly int k;
        private readonly LinkedList<int> nums;

        public _703_数据流中的第K大元素(int k, int[] nums)
        {
            this.k = k;
            this.nums = new LinkedList<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                Insert(nums[i]);
            }
        }

        public int Add(int val)
        {
            Insert(val);

            var node = nums.Last;
            for (int i = 1; i < k && node != null; i++)
            {
                node = node.Previous;
            }

            return node.Value;
        }

        private void Insert(int val)
        {
            if (nums.Count == 0)
            {
                nums.AddFirst(val);
                return;
            }

            var node = nums.First;
            bool notAdded = true;
            while (node != null)
            {
                if (val <= node.Value)
                {
                    nums.AddBefore(node, val);
                    notAdded = false;
                    break;
                }

                node = node.Next;
            }

            if (notAdded)
                nums.AddLast(val);
        }
    }

    /**
     * Your KthLargest object will be instantiated and called as such:
     * KthLargest obj = new KthLargest(k, nums);
     * int param_1 = obj.Add(val);
     */
}