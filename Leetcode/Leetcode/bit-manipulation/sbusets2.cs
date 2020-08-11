using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace Leetcode.bit_manipulation
{
    public class sbusets2
    {
        private IList<IList<int>> res = new List<IList<int>>();
        [Fact]
        public void 子集2()
        {
            //var s = SubsetsWithDup(new int[] { 1, 2, 2 });
            //s.Count.ShouldBe(6);

            var s = SubsetsWithDup(new int[] { 4, 4, 4, 1, 4 });
            s.Count.ShouldBe(10);
        }
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            //先排序，这样相同的两个元素必相邻
            Array.Sort(nums);
            backtrack(nums, new List<int>(), 0);
            return res;
        }
        private void backtrack(int[] nums, List<int> path, int start)
        {
            res.Add(path);

            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1])
                {
                    continue;
                }
                var newPath = new List<int>();
                newPath.AddRange(path);
                newPath.Add(nums[i]);
                backtrack(nums, newPath, i + 1);
            }
        }
    }
}
