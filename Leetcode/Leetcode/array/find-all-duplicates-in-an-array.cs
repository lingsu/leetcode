using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 442. 数组中重复的数据
    /// </summary>
    public class find_all_duplicates_in_an_array
    {
        [Fact]
        public void 数组中重复的数据()
        {
            //FindDuplicates(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }).ShouldBe(new List<int>() { 2, 3 }, ignoreOrder: true);
            FindDuplicates(new int[] { 10, 2, 5, 10, 9, 1, 1, 4, 3, 7 }).ShouldBe(new List<int>() { 10, 1 }, ignoreOrder: true);
        }
        public IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var index = Math.Abs(nums[i]) - 1;
                var v = nums[index];
                if (v < 0)
                {
                    result.Add(Math.Abs(nums[i]));
                }
                nums[index] = -nums[index];
            }
            return result;
        }
    }
}
