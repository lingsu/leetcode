using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace Leetcode.stack
{
    /// <summary>
    /// 用队列实现栈
    /// </summary>
    public class implement_stack_using_queues
    {
        [Fact]
        //[InlineData(1, 1)]
        //[InlineData(2, 2)]
        public void 用队列实现栈()
        {

            MyStack obj = new MyStack();
            obj.Push(1);
            obj.Push(2);
            int param_2 = obj.Pop();
            int param_3 = obj.Top();
            bool param_4 = obj.Empty();
            param_2.ShouldBe(2);
            param_3.ShouldBe(1);
            //param_4.ShouldBeTrue();
        }
        public class MyStack
        {
            private Queue<int> q1 = new Queue<int>();
            private Queue<int> q2 = new Queue<int>();
            /** Initialize your data structure here. */
            private int top;
            public MyStack()
            {

            }

            /** Push element x onto stack. */
            public void Push(int x)
            {
                q1.Enqueue(x);
                top = x;
            }

            /** Removes the element on top of the stack and returns that element. */
            public int Pop()
            {
                //n - 1个元素入队 q2
                //queue 先进先出， stack 后进先出
                while (q1.Count > 1)
                {
                    // top = n - 1 的值
                    top = q1.Dequeue();
                    q2.Enqueue(top);
                }

                var top2 = q1.Dequeue();
                var temp = q2;
                q2 = q1;
                q1 = temp;

                return top2;
            }

            /** Get the top element. */
            public int Top()
            {
                return top;
            }

            /** Returns whether the stack is empty. */
            public bool Empty()
            {
                return q1.Count == 0;
            }
        }

    }
}

