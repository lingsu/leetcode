using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 找不同
    /// </summary>
    public class find_the_difference
    {
        [Fact]
        public void 找不同()
        {
            FindTheDifference("abcd", "abcde").ShouldBe('e');
        }
        public char FindTheDifference(string s, string t)
        {
            var s1 = s.OrderBy(x=>x).ToArray();
            var t1 = t.OrderBy(x=>x).ToArray();

            for (int i = 0; i < t1.Length; i++)
            {
                if (i < s1.Length)
                {
                    if (s1[i] != t1[i])
                    {
                        return t1[i];
                    }
                }
                else
                {
                    return t1[i];
                }
            }
            return '0';
        }
    }
}
