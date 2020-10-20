using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 448. 找到所有数组中消失的数字
    /// </summary>
    public class find_all_numbers_disappeared_in_an_array
    {
        //给定一个范围在  1 ≤ a[i] ≤ n(n = 数组大小) 的 整型数组，数组中的元素一些出现了两次，另一些只出现一次。

        //找到所有在[1, n] 范围之间没有出现在数组中的数字。

        //您能在不使用额外空间且时间复杂度为O(n)的情况下完成这个任务吗? 你可以假定返回的数组不算在额外空间内

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/find-all-numbers-disappeared-in-an-array
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        [Fact]
        public void 找到所有数组中消失的数字()
        {
            FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }).ShouldBe(new int[] { 5, 6 });
        }
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var hash = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                hash[nums[i]] = 1;
            }
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.ContainsKey(i + 1))
                {
                    result.Add(i + 1);
                }
            }
            return result;
        }
    }
}
