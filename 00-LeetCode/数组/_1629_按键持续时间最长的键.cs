using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/slowest-key/
    /// </summary>
    public class _1629_按键持续时间最长的键
    {
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            int[] duration = new int[26];
            for(int i = 0; i < keysPressed.Length; i++)
            {
                if (i == 0)
                    duration[keysPressed[0] - 'a'] = releaseTimes[0];
                else
                {
                    int tmp = releaseTimes[i] - releaseTimes[i - 1];
                    if (tmp > duration[keysPressed[i] - 'a'])
                        duration[keysPressed[i] - 'a'] = tmp;
                }
            }

            int max = 0;
            for(int i = 0; i < duration.Length; i++)
            {
                if (duration[i] > max)
                    max = duration[i];
            }

            for(int i = duration.Length - 1; i >= 0; i--)
            {
                if (duration[i] == max)
                    return (char)(i + 'a');
            }

            return 'a';
        }
    }
}
