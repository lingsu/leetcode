using Shouldly;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 697. 数组的度
    /// </summary>
    public class degree_of_an_array
    {
        //具有度数 d 的数组必须有一些元素 x 出现 d 次。如果某些子数组具有相同的度数，那么某些元素 x （出现 d 次）。最短的子数组是将从 x 的第一次出现到最后一次出现的数组。
        //对于给定数组中的每个元素，让我们知道 left 是它第一次出现的索引； right 是它最后一次出现的索引。例如，当 nums = [1, 2, 3, 2, 5] 时，left[2] = 1 和 right[2] = 3。
        //然后，对于出现次数最多的每个元素 x，right[x] - left[x] + 1 将是我们的候选答案，我们将取这些候选的最小值。

        //作者：LeetCode
        //链接：https://leetcode-cn.com/problems/degree-of-an-array/solution/shu-zu-de-du-by-leetcode/
        //来源：力扣（LeetCode）
        //著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
        [Fact]
        public void 数组的度()
        {
            FindShortestSubArray(new int[] { 1, 2, 2, 3, 1 }).ShouldBe(2);
        }

        public int FindShortestSubArray(int[] nums)
        {

            var left = new Dictionary<int, int>();
            var right = new Dictionary<int, int>();
            var count = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var x = nums[i];
                if (!left.ContainsKey(x))
                {
                    left.Add(x, i);
                }

                right[x] = i;
                count[x] = count.GetValueOrDefault(x, 0) + 1;
            }
            var ans = nums.Length;
            var degree = count.Max(x => x.Value);
            foreach (var x in count)
            {
                if (count[x.Key] == degree)
                {
                    ans = Math.Min(ans, right[x.Key] - left[x.Key] + 1);
                }
            }

            return ans;
        }
    }
}
