using Xunit;
using Shouldly;
using System.Collections.Generic;

namespace Leetcode.stack
{
    /// <summary>
    /// 有效的括号
    /// </summary>
    public class valid_parentheses
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]

        public void 有效的括号(string input, bool result)
        {
            IsValid(input).ShouldBe(result);
        }

        public bool IsValid(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            if (s.Length < 2)
            {
                return false;
            }
            var dic = new Dictionary<char, char>() {
                { ')','(' },
                { ']', '[' },
                { '}', '{' },
            };
            var stack = new Stack<char>();
            stack.Push(s[0]);
            var left = 1;
            while (left < s.Length)
            {
                if (stack.Count > 0 && dic.ContainsKey(s[left]))
                {
                    var top = stack.Peek();
                    if (top == dic[s[left]])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(s[left]);
                    }
                }
                else
                {
                    stack.Push(s[left]);
                }
                left++;
            }

            return stack.Count == 0;
        }

    }
}
