using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 缺失数字
    /// </summary>
    public class missing_number
    {
        [Fact]
        public void 缺失数字()
        {
            MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }).ShouldBe(8);
        }

        public int MissingNumber(int[] nums)
        {
            var missing = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                missing ^= i ^ nums[i];
            }
            return missing;
        }
    }
}
