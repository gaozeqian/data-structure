namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/move-zeroes/
     */
    public class _283_移动零
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1)
                return;

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (i != index)
                        nums[index] = nums[i];

                    index++;
                }
            }

            for (int i = index; i < nums.Length; i++)
                nums[i] = 0;
        }
    }
}