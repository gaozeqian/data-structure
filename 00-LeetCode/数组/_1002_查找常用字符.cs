using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-common-characters/
    /// </summary>
    public class _1002_查找常用字符
    {
        public IList<string> CommonChars(string[] A)
        {
            int[] minFreq = new int[26];
            Array.Fill(minFreq, int.MaxValue);
            int[] freq = new int[26];

            foreach(string str in A)
            {
                foreach(char chr in str)
                {
                    freq[chr - 'a']++;
                }

                for(int i = 0; i < freq.Length; i++)
                {
                    minFreq[i] = Math.Min(minFreq[i], freq[i]);
                    freq[i] = 0;
                }
            }

            List<string> answer = new List<string>();
            for(int i = 0; i < minFreq.Length; i++)
            {
                for(int j = 0; j < minFreq[i]; j++)
                {
                    answer.Add(((char)(i + 'a')).ToString());
                }
            }

            return answer;
        }
    }
}
