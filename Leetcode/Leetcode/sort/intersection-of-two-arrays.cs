using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.sort
{
    /// <summary>
    /// 两个数组的交集
    /// </summary>
    public class intersection_of_two_arrays
    {
        [Fact]
        //给定两个数组，编写一个函数来计算它们的交集。

        //示例 1:

        //输入: nums1 = [1,2,2,1], nums2 = [2,2]
        //        输出: [2]
        //        示例 2:

        //输入: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        //        输出: [9,4]
        //        说明:

        //输出结果中的每个元素一定是唯一的。
        //我们可以不考虑输出结果的顺序。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/intersection-of-two-arrays
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public void 两个数组的交集()
        {
            Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }).ShouldBe(new int[] { 2 });
        }
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var dic = new Dictionary<int, int>();
            foreach (var item in nums1)
            {
                dic[item] = 0;
            }

            foreach (var item in nums2)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
            }
            return dic.Where(x => x.Value > 0).Select(x => x.Key).ToArray();
        }
    }
}
