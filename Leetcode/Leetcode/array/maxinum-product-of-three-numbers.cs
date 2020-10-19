using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 628. 三个数的最大乘积
    /// </summary>
    public class maxinum_product_of_three_numbers
    {
        [Fact]
        public void 三个数的最大乘积()
        {
            //MaximumProduct(new int[] { 1, 2, 3 }).ShouldBe(6);
            MaximumProduct(new int[] { -4, -3, -2, -1, 60 }).ShouldBe(720);
        }
        public int MaximumProduct(int[] nums)
        {
            var a = int.MinValue;
            var b = int.MinValue;
            var c = int.MinValue;

            var ma = int.MaxValue;
            var mb = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];

                if (cur <= ma)
                {
                    mb = ma;
                    ma = cur;
                }
                else if (cur <= mb)
                {
                    mb = cur;
                }

                if (cur >= a)
                {
                    c = b;
                    b = a;
                    a = nums[i];
                }
                else if (cur >= b)
                {
                    c = b;
                    b = nums[i];
                }
                else if (cur >= c)
                {
                    c = nums[i];
                }
            }

            return Math.Max(a * b * c,  ma * mb * a);
        }
    }
}
