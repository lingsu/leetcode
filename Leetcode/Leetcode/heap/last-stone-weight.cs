﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.heap
{
    /// <summary>
    /// 最后一块石头的重量
    /// </summary>
    public class last_stone_weight
    {
        [Fact]
        public void 最后一块石头的重量()
        {
            LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 }).ShouldBe(1);
        }
        //有一堆石头，每块石头的重量都是正整数。

        //每一回合，从中选出两块 最重的 石头，然后将它们一起粉碎。假设石头的重量分别为 x 和 y，且 x <= y。那么粉碎的可能结果如下：

        //如果 x == y，那么两块石头都会被完全粉碎；
        //如果 x != y，那么重量为 x 的石头将会完全粉碎，而重量为 y 的石头新重量为 y-x。
        //最后，最多只会剩下一块石头。返回此石头的重量。如果没有石头剩下，就返回 0。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/last-stone-weight
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int LastStoneWeight(int[] stones)
        {
            if (!stones.Any())
            {
                return 0;
            }
            if (stones.Length == 1)
            {
                return stones[0];
            }

            var list = stones.OrderByDescending(x => x).ToList();
            while (list.Count > 1)
            {
                var top2 = list.Take(2).ToArray();
                var x = top2[1];
                var y = top2[0];
                
                if (x == y)
                {
                    list = list.Skip(2).ToList();
                }
                else
                {
                    var newList = list.Skip(2).ToList();
                    newList.Add(y - x);
                    list = newList.OrderByDescending(x => x).ToList();
                }
            }
            if (list.Count == 1)
            {
                return list[0];
            }
            return 0;
        }
    }
}
