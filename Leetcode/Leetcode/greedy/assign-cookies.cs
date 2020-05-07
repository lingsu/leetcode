using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.greedy
{
    /// <summary>
    /// 分发饼干
    /// </summary>
    public class assign_cookies
    {
        [Fact]
        //假设你是一位很棒的家长，想要给你的孩子们一些小饼干。但是，每个孩子最多只能给一块饼干。对每个孩子 i ，都有一个胃口值 gi ，这是能让孩子们满足胃口的饼干的最小尺寸；并且每块饼干 j ，都有一个尺寸 sj 。如果 sj >= gi ，我们可以将这个饼干 j 分配给孩子 i ，这个孩子会得到满足。你的目标是尽可能满足越多数量的孩子，并输出这个最大数值。

        //注意：

        //你可以假设胃口值为正。
        //一个小朋友最多只能拥有一块饼干。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/assign-cookies
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public void 分发饼干()
        {
            FindContentChildren(new int[] { 1, 2, 3 }, new int[] { 1, 1 }).ShouldBe(1);
            
        }
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            var count = 0;
            var i = 0;
            foreach (var g1 in g)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (s[j] >= g1)
                    {
                        count++;
                        i = j + 1;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
