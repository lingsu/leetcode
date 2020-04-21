using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace Leetcode.stack
{
    /// <summary>
    /// 比较含退格的字符串
    /// </summary>
    public class backspace_string_compare
    {
        [Fact]
        public void 比较含退格的字符串()
        {
            BackspaceCompare("ab#c", "ad#c").ShouldBeTrue();
            BackspaceCompare("ab##", "c#d#").ShouldBeTrue();
            BackspaceCompare("a#c", "b").ShouldBeFalse();
        }
        //        给定 S 和 T 两个字符串，当它们分别被输入到空白的文本编辑器后，判断二者是否相等，并返回结果。 # 代表退格字符。

        //注意：如果对空文本输入退格字符，文本继续为空。



        //示例 1：

        //输入：S = "ab#c", T = "ad#c"
        //输出：true
        //解释：S 和 T 都会变成 “ac”。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/backspace-string-compare
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public bool BackspaceCompare(string S, string T)
        {
            return Build(S) == Build(T);
        }

        private string Build(string S)
        {
            var stack = new Stack<char>();

            foreach (var c in S)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            return string.Join("", stack);
        }
    }
}
