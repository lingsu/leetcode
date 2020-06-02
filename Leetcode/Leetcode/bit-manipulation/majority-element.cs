using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 多数元素
    /// </summary>
    public class majority_element
    {
        //        给定一个大小为 n 的数组，找到其中的多数元素。多数元素是指在数组中出现次数大于 ⌊ n/2 ⌋ 的元素。

        //你可以假设数组是非空的，并且给定的数组总是存在多数元素。



        //示例 1:

        //输入: [3,2,3]
        //        输出: 3
        //示例 2:

        //输入: [2,2,1,1,1,2,2]
        //        输出: 2

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/majority-element
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        [Fact]
        public void 多数元素()
        {
            MajorityElement(new int[] { 3, 2, 3 }).ShouldBe(3);
            MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }).ShouldBe(2);
            MajorityElement(new int[] { 3,3,4 }).ShouldBe(3);
        }
        public int MajorityElement(int[] nums)
        {
            var dic = new Dictionary<int, int>();

            foreach (var i in nums)
            {
                if (!dic.ContainsKey(i))
                {
                    dic[i] = 0;
                }
                dic[i]++;
            }

            return dic.OrderByDescending(x => x.Value).First().Key;
        }
    }
}
