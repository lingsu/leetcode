using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.stack
{
    /// <summary>
    /// 栈的最小值
    /// </summary>
    public class min_stack_lcci
    {
        [Fact]
        public void 栈的最小值()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.GetMin().ShouldBe(-3); //--> 返回 - 3.
            minStack.Pop();
            minStack.Top().ShouldBe(0); //--> 返回 0.
            minStack.GetMin().ShouldBe(-2);// --> 返回 - 2.

        }

        //        请设计一个栈，除了常规栈支持的pop与push函数以外，还支持min函数，该函数返回栈元素中的最小值。执行push、pop和min操作的时间复杂度必须为O(1)。
        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/min-stack-lcci
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public class MinStack
        {
            private Stack<int> stack = new Stack<int>();
            private int min = int.MaxValue;
            /** initialize your data structure here. */
            public MinStack()
            {

            }

            public void Push(int x)
            {
                if (min >= x)
                {
                    if (stack.Count > 0)
                    {
                        stack.Push(min);
                    }

                    min = x;
                }

                stack.Push(x);
            }

            public void Pop()
            {
                if (stack.Count == 0)
                {
                    return;
                }

                if (stack.Count == 1)
                {
                    min = int.MaxValue;
                }
                else if(stack.Peek() == min)
                {
                    stack.Pop();
                    min = stack.Peek();
                }

                stack.Pop();
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return min;
            }
        }

    }
}
