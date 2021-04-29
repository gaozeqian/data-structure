using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /**
     * https://leetcode-cn.com/problems/plus-one/
     */
    public class _66_加一
    {
        public int[] PlusOne(int[] digits)
        {
            for(int i = digits.Length - 1; i >= 0; i--)
            {
                if(i == 0)
                {
                    digits[0] += 1;
                    if(digits[0] <= 9)
                    {
                        break;
                    }
                    else
                    {
                        digits = new int[digits.Length + 1];
                        digits[0] = 1;
                    }
                }
                else
                {
                    digits[i] += 1;
                    if(digits[i] <= 9)
                    {
                        break;
                    }
                    else
                    {
                        digits[i] = 0;
                    }
                }
            }

            return digits;
        }
    }
}
