using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/day-of-the-week/
    /// </summary>
    public class _1185_一周中的第几天
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            string[] week = new string[]
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            int c = (month <= 2 ? year - 1 : year) / 100;
            int y = (month <= 2 ? year - 1 : year) % 100;
            int m = month <= 2 ? month + 12 : month;
            int d = day;
            int w = y + y / 4 + c / 4 - 2 * c + 26 * (m + 1) / 10 + d - 1;
            w = (w % 7 + 7) % 7;

            return week[w];
        }
    }
}
