using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.stack
{
    /// <summary>
    /// 数据流中的第K大元素
    /// </summary>
    public class kth_largest_element_in_a_stream
    {
        [Fact]
        //        设计一个找到数据流中第K大元素的类（class）。注意是排序后的第K大元素，不是第K个不同的元素。

        //你的 KthLargest 类需要一个同时接收整数 k 和整数数组nums 的构造器，它包含数据流中的初始元素。每次调用 KthLargest.add，返回当前数据流中第K大的元素。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/kth-largest-element-in-a-stream
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public void 数据流中的第K大元素()
        {
            KthLargest obj = new KthLargest(3, new[] { 4, 5, 8, 2 });
            obj.Add(3).ShouldBe(4);
            //23458
            obj.Add(5).ShouldBe(5);
            obj.Add(10).ShouldBe(5);
            obj.Add(9).ShouldBe(8);
        }

        //最笨的方式
        public class KthLargest
        {
            private int k;
            private int[] nums;
            private List<int> list = new List<int>();
            public KthLargest(int k, int[] nums)
            {
                this.k = k;
                this.nums = nums;
                foreach (var item in nums)
                {
                    list.Add(item);
                }
            }

            public int Add(int val)
            {
                list.Add(val);
           
                return list.OrderByDescending(x=>x).ToList()[k -1];
            }
        }

    }
}
