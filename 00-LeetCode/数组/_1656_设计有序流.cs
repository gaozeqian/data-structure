using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/design-an-ordered-stream/
    /// </summary>
    public class _1656_设计有序流
    {
        private string[] str;
        int ptr;

        public _1656_设计有序流(int n)
        {
            str = new string[n + 1];
            ptr = 0;
        }

        public IList<string> Insert(int idKey, string value)
        {
            str[idKey - 1] = value;

            List<string> ans = new List<string>();
            while(!string.IsNullOrWhiteSpace(str[ptr]))
                ans.Add(str[ptr++]);
            return ans;
        }
    }

    /**
     * Your OrderedStream object will be instantiated and called as such:
     * OrderedStream obj = new OrderedStream(n);
     * IList<string> param_1 = obj.Insert(idKey,value);
     */
}
