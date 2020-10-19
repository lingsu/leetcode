using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace Leetcode.array
{
    /// <summary>
    /// 414. 第三大的数
    /// </summary>
    public class third_maximum_number
    {
        [Fact]
        public void 第三大的数()
        {
            ThirdMax(new int[] { 1, 2, 3 }).ShouldBe(1);
            ThirdMax(new int[] { 1, 2, 3 }).ShouldBe(1);
        }
        public int ThirdMax(int[] nums)
        {
            var a = nums[0];
            var b = long.MinValue;
            var c = long.MinValue;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == a || nums[i] == b || nums[i] == c)
                {
                    continue;
                }
                if (nums[i] > a)
                {
                    c = b;
                    b = a;
                    a = nums[i];
                }
                else if (nums[i] > b)
                {
                    c = b;
                    b = nums[i];
                }
                else if (nums[i] > c)
                {
                    c = nums[i];
                }
            }
            if (c == long.MinValue)
            {
                return a;
            }
            return (int)c;
        }
    }
}
