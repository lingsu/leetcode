using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.stack
{
    /// <summary>
    /// 删除字符串中的所有相邻重复项
    /// </summary>
    public class remove_all_adjacent_duplicates_in_string
    {
        [Fact]
        public void 删除字符串中的所有相邻重复项()
        {
            RemoveDuplicates("abbaca").ShouldBe("ca");
        }
        public string RemoveDuplicates(string S)
        {
            var stack = new Stack<char>();

            foreach (var c in S)
            {
                if (stack.Count == 0)
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Peek() != c)
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        while (stack.Count > 0 && stack.Peek() == c)
                        {
                            stack.Pop();
                        }
                    }
                    
                   
                }
            }
            return string.Join("", stack.ToArray().Reverse());
        }
    }
}
