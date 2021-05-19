using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/number-of-students-doing-homework-at-a-given-time/
    /// </summary>
    public class _1450_在既定时间做作业的学生人数
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int students = 0;
            for(int i = 0; i < endTime.Length; i++)
            {
                if (queryTime >= startTime[i] && queryTime <= endTime[i])
                    students++;
            }

            return students;
        }
    }
}
