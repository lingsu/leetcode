using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.bit_manipulation
{
    public class convert_binary_number_in_a_linked_list_to_integer
    {
        [Fact]
        public void 二进制链表转整数()
        {
            GetDecimalValue(new ListNode() { val = 1, next = new ListNode() { next = new ListNode() { val = 1 } } }).ShouldBe(5);
        }
        public int GetDecimalValue(ListNode head)
        {
            var node = head;
            var bit = 0;
            while (node != null)
            {
                bit ^= node.val;
                node = node.next;
                if (node != null)
                {
                    bit <<= 1;
                }
            }

            return bit;
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
        }

    }
}
