using System;
using System.Collections.Generic;
using System.Text;

namespace _00_LeetCode.栈
{
    /**
     * https://leetcode-cn.com/problems/crawler-log-folder/
     */
    public class _1598_文件夹操作日志搜集器
    {
        public int MinOperations(string[] logs)
        {
            var folderStack = new Stack<string>();

            foreach(var log in logs)
            {
                if("../".Equals(log))
                {
                    if (folderStack.Count > 0) folderStack.Pop();
                }
                else if(!"./".Equals(log))
                {
                    folderStack.Push(log);
                }
            }

            return folderStack.Count;
        }
    }
}
