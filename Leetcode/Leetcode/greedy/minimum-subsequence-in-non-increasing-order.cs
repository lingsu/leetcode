using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.greedy
{
    /// <summary>
    /// 非递增顺序的最小子序列
    /// </summary>
    public class minimum_subsequence_in_non_increasing_order
    {
        [Fact]
        //给你一个数组 nums，请你从中抽取一个子序列，满足该子序列的元素之和 严格 大于未包含在该子序列中的各元素之和。

        //如果存在多个解决方案，只需返回 长度最小 的子序列。如果仍然有多个解决方案，则返回 元素之和最大 的子序列。

        //与子数组不同的地方在于，「数组的子序列」不强调元素在原数组中的连续性，也就是说，它可以通过从数组中分离一些（也可能不分离）元素得到。

        //注意，题目数据保证满足所有约束条件的解决方案是 唯一 的。同时，返回的答案应当按 非递增顺序 排列。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/minimum-subsequence-in-non-increasing-order
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public void 非递增顺序的最小子序列()
        {
            MinSubsequence(new int[] { 4, 3, 10, 9, 8 }).ShouldBe(new List<int>() { 10, 9 });
        }
        public IList<int> MinSubsequence(int[] nums)
        {
            var total = nums.Sum() / 2;
            var result = new List<int>();
            foreach (var i in nums.OrderByDescending(x => x))
            {
                result.Add(i);
                if (result.Sum() > total)
                {
                    break;
                }
            }

            return result;
        }
    }
}
