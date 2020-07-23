using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 4的幂
    /// </summary>
    public class power_of_four
    {
        [Fact]
        //给定一个整数 (32 位有符号整数)，请编写一个函数来判断它是否是 4 的幂次方。
        public void _4的幂()
        {
            IsPowerOfFour(16).ShouldBeTrue();
            IsPowerOfFour(5).ShouldBeFalse();
        }
        public bool IsPowerOfFour(int num)
        {
            if (num == 0)
            {
                return false;
            }
            while (num % 4 == 0)
            {
                num /= 4;
            }
            return num == 1;
        }
    }
}
