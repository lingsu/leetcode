using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 最大连续1的个数
    /// </summary>
    public class max_consecutive_ones
    {
        [Fact]
        public void 最大连续1的个数()
        {
            FindMaxConsecutiveOnes(new[] { 1, 1, 0, 1, 1, 1 }).ShouldBe(3);
        }
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var max = int.MinValue;
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        if (count > max)
                        {
                            max = count;
                        }
                        count = 0;
                    }
                }
            }
            if (count > max)
            {
                max = count;
            }
            return max;
        }
    }
}
