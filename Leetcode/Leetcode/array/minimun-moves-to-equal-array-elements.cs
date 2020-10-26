using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 453. 最小移动次数使数组元素相等
    /// </summary>
    public class minimun_moves_to_equal_array_elements
    {
        [Fact]
        public void 最小移动次数使数组元素相等暴力法()
        {
            MinMoves(new int[] { 1, 2, 3 }).ShouldBe(3);
        }
        [Fact]
        public void 最小移动次数使数组元素相等改进暴力法()
        {
            MinMoves2(new int[] { 1, 2, 3 }).ShouldBe(3);
        }
        [Fact]
        public void 最小移动次数使数组元素相数学法()
        {
            MinMoves3(new int[] { 1, 2, 3 }).ShouldBe(3);
        }
        /// <summary>
        /// 首先,我们知道,为了在最小移动内使所有元素相等，我们需要在数组的最大元素之外的所有元素中执行增加。因此,在暴力法中，我们扫描整个数组以查找最大值和最小元素。此后，我们将 11 添加到除最大元素之外的所有元素，并增加移动数的计数。同样，我们重复相同的过程，直到最大元素和最小元素彼此相等。
        //        作者：LeetCode
        //        链接：https://leetcode-cn.com/problems/minimum-moves-to-equal-array-elements/solution/zui-xiao-yi-dong-ci-shu-shi-shu-zu-yuan-su-xiang-d/
        //来源：力扣（LeetCode）
        //著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinMoves(int[] nums)
        {
            var min = 0;
            var max = 0;
            var count = 0;

            while (true)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < nums[min])
                    {
                        min = i;
                    }

                    if (nums[i] > nums[max])
                    {
                        max = i;
                    }
                }

                if (nums[max] == nums[min])
                {
                    break;
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != max)
                    {
                        nums[i]++;
                    }
                }
                count++;

            }

            return count;
        }
        public int MinMoves2(int[] nums)
        {
            var min = 0;
            var max = 0;
            var count = 0;

            while (true)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < nums[min])
                    {
                        min = i;
                    }

                    if (nums[i] > nums[max])
                    {
                        max = i;
                    }
                }

                var diff = nums[max] - nums[min];
                if (diff == 0)
                {
                    break;
                }

                count += diff;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != max)
                    {
                        nums[i] += diff;
                    }
                }
            }

            return count;
        }


        public int MinMoves3(int[] nums)
        {
            Array.Sort(nums);
            var count = 0;

            for (int i = nums.Length - 1; i > 0; i--)
            {
                count += nums[i] - nums[0];
            }

            return count;
        }
    }
}
