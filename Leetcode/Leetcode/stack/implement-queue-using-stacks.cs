using System;
using System.Collections.Generic;
using Xunit;
using Shouldly;

namespace Leetcode.stack
{
    /// <summary>
    /// 用栈实现队列
    /// </summary>
    public class implement_queue_using_stacks
    {
        [Fact]
        public void 用栈实现队列()
        {
            MyQueue obj = new MyQueue();
            obj.Push(1);
            obj.Push(2);
            int param_2 = obj.Pop();
            int param_3 = obj.Peek();
            bool param_4 = obj.Empty();

            param_2.ShouldBe(1);
            param_3.ShouldBe(2);
        }
        public class MyQueue
        {
            private Stack<int> s1 = new Stack<int>();
            private Stack<int> s2 = new Stack<int>();
            /** Initialize your data structure here. */
            private int front;
            public MyQueue()
            {

            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                if (s1.Count == 0)
                {
                    front = x;
                }
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
                s2.Push(x);
                while (s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                }
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                var pop = s1.Pop();
                if (s1.Count > 0)
                {
                    front = s1.Peek();
                }
                return pop;
            }

            /** Get the front element. */
            public int Peek()
            {
                return front;
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return s1.Count == 0;
            }
        }
    }
}
