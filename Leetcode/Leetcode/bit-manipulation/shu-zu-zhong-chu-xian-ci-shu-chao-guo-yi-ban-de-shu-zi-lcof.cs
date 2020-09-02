using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 数组中出现次数超过一半的数字
    /// </summary>
    public class shu_zu_zhong_chu_xian_ci_shu_chao_guo_yi_ban_de_shu_zi_lcof
    {
        [Fact]
        public void 数组中出现次数超过一半的数字()
        {
            MajorityElement(new int[] { 1, 2, 3, 2, 2, 2, 5, 4, 2 }).ShouldBe(2);
        }
        public int MajorityElement(int[] nums)
        {
            var count = 0;
            var half = nums.Length / 2;
            var fist = 0;
            foreach (var item in nums.OrderBy(x => x))
            {
                if (item == fist)
                {
                    count++;
                }
                else
                {
                    if (count > half)
                    {
                        break;
                    }
                    count = 1;
                    fist = item;
                }
            }
            return fist;
        }
    }
}
