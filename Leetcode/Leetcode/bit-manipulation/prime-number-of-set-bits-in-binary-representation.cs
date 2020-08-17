using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace Leetcode.bit_manipulation
{
    public class prime_number_of_set_bits_in_binary_representation
    {
        [Theory]
        [InlineData(6, 10, 4)]
        public void 二进制表示中质数个计算置位(int L, int R, int result)
        {
            CountPrimeSetBits(L, R).ShouldBe(result);
        }
        public int CountPrimeSetBits(int L, int R)
        {
            var count = 0;
            //0-20的质数列表，prime[i]为1，则i为质数
            int[] primes = { 0, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1 };

            for (int i = L; i <= R; i++)
            {
                var j = i;
                var len = 0;
                do
                {
                    var lowbit1 = j & 1;
                    len += lowbit1;
                    j >>= 1;
                } while (j != 0);

                count += primes[len];
            }
            return count;
        }
    }
}
