using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/number-of-students-unable-to-eat-lunch/
    /// </summary>
    public class _1700_无法吃午餐的学生数量
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int[] countStu = new int[2];
            foreach (int num in students)
                countStu[num]++;

            int[] countSw = new int[2];
            foreach (int num in sandwiches)
                countSw[num]++;

            if (countStu[0] == countSw[0])
                return 0;

            for (int i = 0; i < sandwiches.Length; i++)
            {
                if (countStu[0] == 0 && sandwiches[i] == 0)
                    break;

                if (countStu[1] == 0 && sandwiches[i] == 1)
                    break;

                if (sandwiches[i] == 0)
                    countStu[0]--;
                else
                    countStu[1]--;
            }

            return Math.Max(countStu[0], countStu[1]);
        }
    }
}
