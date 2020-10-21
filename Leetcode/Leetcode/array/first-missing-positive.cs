using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 41. 缺失的第一个正数
    /// </summary>
    public class first_missing_positive
    {
        [Fact]
        public void 缺失的第一个正数()
        {
            FirstMissingPositive(new int[] { 1, 1 }).ShouldBe(2);
            FirstMissingPositive(new int[] { 1, 2, 0 }).ShouldBe(3);
            FirstMissingPositive(new int[] { 3, 4, -1, 1 }).ShouldBe(2);
            FirstMissingPositive(new int[] { 7, 8, 9, 11, 12 }).ShouldBe(1);
        }
        public int FirstMissingPositive(int[] nums)
        {
            var minimum = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                var val = nums[i];
                if (val <= 0)
                {
                    nums[i] = nums.Length + 1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var val = Math.Abs(nums[i]);
                if (val <= nums.Length)
                {
                    nums[val - 1] = -Math.Abs(nums[val - 1]);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var val = nums[i];
                if (val > 0)
                {
                    return i + 1;
                }
            }

            return minimum + 1;
        }
    }
}
