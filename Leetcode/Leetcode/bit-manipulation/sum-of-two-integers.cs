using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 两整数之和
    /// </summary>
    public class sum_of_two_integers
    {
        [Fact]
        public void 两整数之和()
        {
            GetSum(1, 2).ShouldBe(3);
        }
        public int GetSum(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }
            int lower;
            int carrier;
            while (true)
            {
                lower = a ^ b;
                carrier = a & b;
                if (carrier == 0)
                {
                    break;
                }
                a = lower;
                b = carrier << 1;
            }

            return lower;
        }
    }
}
