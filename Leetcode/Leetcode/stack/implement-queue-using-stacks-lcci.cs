using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;


namespace Leetcode.stack
{
    /// <summary>
    /// 化栈为队
    /// </summary>
    public class implement_queue_using_stacks_lcci
    {
        [Fact]
        public void 化栈为队()
        {
            MyQueue queue = new MyQueue();

            queue.Push(1);
            queue.Push(2);
            queue.Peek().ShouldBe(1);  // 返回 1
            queue.Pop().ShouldBe(1);   // 返回 1
            queue.Empty().ShouldBeFalse(); // 返回 false


        }

        public class MyQueue
        {
            private Stack<int> s1 = new Stack<int>();
            private Stack<int> s2 = new Stack<int>();
            /** Initialize your data structure here. */
            public MyQueue()
            {

            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
                s1.Push(x);
                while (s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                }
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                return s1.Pop();
            }

            /** Get the front element. */
            public int Peek()
            {
                return s1.Peek();
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return s1.Count == 0;
            }
        }
    }
}
