using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.heap
{
    /// <summary>
    /// 最小的k个数
    /// </summary>
    public class zui_xiao_de_kge_shu_lcof
    {
        [Fact]
        public void 最小的k个数()
        {

            GetLeastNumbers(new int[] { 3, 2, 1 }, 2).ShouldBe(new int[] { 1,2 });
        }
        /// <summary>
        /// 排序法
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] GetLeastNumbers(int[] arr, int k)
        {
            return arr.OrderBy(x => x).Take(k).ToArray();
        }
    }
}
