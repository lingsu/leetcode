using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 颠倒二进制位
    /// </summary>
    public class reverse_bits
    {
        [Fact]
        public void 颠倒二进制位()
        {
            ((int)reverseBits(43261596)).ShouldBe(964176192);
        }
        public uint reverseBits(uint n)
        {
            uint ret = 0;
            var power = 31;
            while (n > 0)
            {
                ret += (n & 1) << power;
                n = n >> 1;
                power -= 1;
            }

            return ret;
        }
    }
}
