using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.bit_manipulation
{
    public class number_of_steps_to_reduce_a_number_to_zero
    {
        [Theory]
        [InlineData(14,6)]
        public void 将数字变成0的操作次数(int num,int result)
        {
            NumberOfSteps(num).ShouldBe(result);
        }
        public int NumberOfSteps(int num)
        {
            var res = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num >>= 1;
                }
                else
                {
                    num = num - 1;
                }
                res++;
            }

            return res;
        }
    }
}
