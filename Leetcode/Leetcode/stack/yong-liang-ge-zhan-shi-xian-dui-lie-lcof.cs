using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace Leetcode.stack
{
    /// <summary>
    /// 用两个栈实现队列
    /// </summary>
    public class yong_liang_ge_zhan_shi_xian_dui_lie_lcof
    {
        public void 用两个栈实现队列()
        {
            CQueue obj = new CQueue();
            obj.AppendTail(2);
            int param_2 = obj.DeleteHead();
        }

        public class CQueue
        {
            private Stack<int> s1 = new Stack<int>();
            private Stack<int> s2 = new Stack<int>();

            public CQueue()
            {

            }

            public void AppendTail(int value)
            {
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
                s1.Push(value);
                while (s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                }
            }

            public int DeleteHead()
            {
                if (s1.Count > 0)
                {
                    return s1.Pop();
                }
                return -1;
            }
        }


    }
}
