namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/can-place-flowers/
    /// </summary>
    public class _605_种花问题
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n == 0)
                return true;

            int counter = 1;
            for(int i = 0; i < flowerbed.Length; i++)
            {
                if(counter == 3)
                {
                    n--;
                    counter = 1;
                }

                if (n == 0)
                    return true;

                if (flowerbed[i] == 0)
                    counter++;
                else
                    counter = 0;
            }

            if (counter >= 2)
                n--;

            if (n == 0)
                return true;

            return false;
        }
    }
}
