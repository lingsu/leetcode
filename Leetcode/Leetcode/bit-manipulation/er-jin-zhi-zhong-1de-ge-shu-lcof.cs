using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 二进制中1的个数
    /// </summary>
    public class er_jin_zhi_zhong_1de_ge_shu_lcof
    {
        [Theory]
        [InlineData(9,2)]
        [InlineData(128,1)]
        public void 二进制中1的个数(uint n, int result)
        {
            HammingWeight(n).ShouldBe(result);
        }
        public int HammingWeight(uint n)
        {
            var res = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    res++;
                }
                n >>= 1;
            }

            return res;
        }
    }
}
