using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.greedy
{
    /// <summary>
    /// 分割平衡字符串
    /// </summary>
    public class split_a_string_in_balanced_strings
    {
        [Fact]
        //在一个「平衡字符串」中，'L' 和 'R' 字符的数量是相同的。

        //给出一个平衡字符串 s，请你将它分割成尽可能多的平衡字符串。

        //返回可以通过分割得到的平衡字符串的最大数量。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/split-a-string-in-balanced-strings
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public void 分割平衡字符串()
        {
            BalancedStringSplit("RLRRLLRLRL").ShouldBe(4);
            BalancedStringSplit("RLLLLRRRLR").ShouldBe(3);
            BalancedStringSplit("LLLLRRRR").ShouldBe(1);
        }
        public int BalancedStringSplit(string s)
        {
            var maxNumber = 0;
            var balance = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    balance++;
                }
                else
                {
                    balance--;
                }
                if (balance == 0)
                {
                    maxNumber++;
                }
            }

            return maxNumber;
        }
    }
}
