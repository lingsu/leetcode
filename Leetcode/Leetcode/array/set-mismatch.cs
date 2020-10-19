using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 645. 错误的集合
    /// </summary>
    public class set_mismatch
    {
        [Fact]
        public void 错误的集合()
        {
            FindErrorNums(new int[] { 1, 2, 2, 4 }).ShouldBe(new int[] { 2, 3 });
        }
        public int[] FindErrorNums(int[] nums)
        {
            var result = new int[2];

            var dup = -1;
            var missing = -1;

            for (int i = 1; i <= nums.Length; i++)
            {
                var count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == i)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    dup = i;
                }
                if (count == 0)
                {
                    missing = i;
                }
                if (dup > 0 && missing > 0)
                    break;
            }

            result[0] = dup;
            result[1] = missing;

            return result;
        }
    }
}
