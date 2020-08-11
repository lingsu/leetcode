using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace Leetcode.bit_manipulation
{

    public class subsets
    {
        private IList<IList<int>> res = new List<IList<int>>();
        [Fact]
        public void 子集()
        {
            var s = Subsets(new int[] { 1, 2, 3 });
            s.Count.ShouldBe(8);
        }
        public IList<IList<int>> Subsets(int[] nums)
        {
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    backtrack(nums, )
            //}
            backtrack(nums, new List<int>(), 0);
            return res;
        }
        /// <summary>
        /// 回溯
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="path"></param>
        /// <param name="start"></param>
        private void backtrack(int[] nums, List<int> path, int start)
        {
            res.Add(path);
           
            for (int i = start; i < nums.Length; i++)
            {
                var newPath = new List<int>();
                newPath.AddRange(path);
                newPath.Add(nums[i]);//做出选择
                backtrack(nums, newPath, i + 1);//递归进入下一层，注意i+1，标识下一个选择列表的开始位置，最重要的一步
                //path2.Remove(path2.Count - 1);
            }
        }
    }
}
