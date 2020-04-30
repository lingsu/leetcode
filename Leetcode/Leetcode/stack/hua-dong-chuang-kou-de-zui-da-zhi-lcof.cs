using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.stack
{
    /// <summary>
    /// 滑动窗口的最大值
    /// </summary>
    public class hua_dong_chuang_kou_de_zui_da_zhi_lcof
    {
        [Fact]
        public void 滑动窗口的最大值()
        {
            MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3).ShouldBe(new int[] { 3,3,5,5,6,7});
        }
        /// <summary>
        /// 给定一个数组 nums 和滑动窗口的大小 k，请找出所有滑动窗口里的最大值。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                return nums;
            }
            var resule = new int[nums.Length - k + 1];
            for (int i = 0; i < nums.Length - k + 1; i++)
            {
                resule[i] = nums.Skip(i).Take(k).Max();
            }
            return resule;
        }
    }
}
