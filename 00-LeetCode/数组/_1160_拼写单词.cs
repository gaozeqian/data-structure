using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/find-words-that-can-be-formed-by-characters/
    /// </summary>
    public class _1160_拼写单词
    {
        public int CountCharacters(string[] words, string chars)
        {
            int[] chr = new int[26];
            foreach(char c in chars)
            {
                chr[c - 'a']++;
            }

            int answer = 0;
            int[] tmp = new int[26];
            int index = 0;
            foreach(string word in words)
            {
                Array.Copy(chr, tmp, 26);
                for(index = 0; index < word.Length; index++)
                {
                    if (--tmp[word[index] - 'a'] < 0)
                        break;
                }

                if(index == word.Length)
                {
                    answer += index;
                }
            }

            return answer;
        }
    }
}
