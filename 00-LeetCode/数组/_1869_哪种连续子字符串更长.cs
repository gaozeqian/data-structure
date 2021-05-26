using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/longer-contiguous-segments-of-ones-than-zeros/
    /// </summary>
    public class _1869_哪种连续子字符串更长
    {
        public bool CheckZeroOnes(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>
            {
                { '1', 0 },
                { '0', 0 }
            };

            int continueLength = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if(!s[i].Equals(s[i - 1]))
                {
                    if (continueLength > dic[s[i - 1]])
                        dic[s[i - 1]] = continueLength;
                    continueLength = 0;
                }

                continueLength++;
            }

            if (continueLength > dic[s[s.Length - 1]])
                dic[s[s.Length - 1]] = continueLength;

            return dic['1'] > dic['0'];
        }
    }
}
