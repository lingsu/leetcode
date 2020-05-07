using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;
namespace Leetcode.greedy
{
    /// <summary>
    /// 判断子序列
    /// </summary>
    public class is_subsequence
    {
        [Fact]
        public void 判断子序列()
        {
            IsSubsequence("abc", "ahbgdc").ShouldBeTrue();
            IsSubsequence("abc", "ahbgdc").ShouldBeTrue();
        }
        public bool IsSubsequence(string s, string t)
        {
            var i = -1;
            foreach (var s1 in s)
            {
                i = t.IndexOf(s1, i + 1);
                if (i == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
    
}
