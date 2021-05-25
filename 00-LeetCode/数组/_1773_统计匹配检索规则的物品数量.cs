using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _00_LeetCode.数组
{
    /// <summary>
    /// https://leetcode-cn.com/problems/count-items-matching-a-rule/
    /// </summary>
    public class _1773_统计匹配检索规则的物品数量
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            return items.Where(
                item => ("type".Equals(ruleKey) && item[0].Equals(ruleValue)) || 
                ("color".Equals(ruleKey) && item[1].Equals(ruleValue)) || 
                ("name".Equals(ruleKey) && item[2].Equals(ruleValue))).Count();
        }
    }
}
