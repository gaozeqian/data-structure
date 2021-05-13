using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/relative-sort-array/
    /// </summary>
    public class _1122_数组的相对排序
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach(var num in arr1)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);
            }

            int[] answer = new int[arr1.Length];
            int index = 0;
            foreach (var num in arr2)
            {
                for(int i = 0; i < dic[num]; i++)
                {
                    answer[index++] = num;
                }
                dic.Remove(num);
            }

            int sortfrom = index;
            foreach(var item in dic)
            {
                for (int i = 0; i < item.Value; i++)
                    answer[index++] = item.Key;
            }
            Array.Sort(answer, sortfrom, answer.Length - sortfrom);

            return answer;
        }
    }
}
