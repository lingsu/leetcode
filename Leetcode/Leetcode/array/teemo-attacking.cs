using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 提莫攻击
    /// </summary>
    public class teemo_attacking
    {
        //        在《英雄联盟》的世界中，有一个叫 “提莫” 的英雄，他的攻击可以让敌方英雄艾希（编者注：寒冰射手）进入中毒状态。现在，给出提莫对艾希的攻击时间序列和提莫攻击的中毒持续时间，你需要输出艾希的中毒状态总时长。

        //你可以认为提莫在给定的时间点进行攻击，并立即使艾希处于中毒状态。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/teemo-attacking
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        [Fact]
        public void 提莫攻击()
        {
            FindPoisonedDuration(new int[] { 1, 4 }, 2).ShouldBe(4);
            FindPoisonedDuration(new int[] { 1, 2 }, 2).ShouldBe(3);
        }
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            if (timeSeries.Length == 0)
            {
                return 0;
            }
            if (timeSeries.Length == 1)
            {
                return duration;
            }
            var times = 0;
            for (int i = 1; i < timeSeries.Length; i++)
            {
                var dif = timeSeries[i] - timeSeries[i - 1];
                if (dif >= duration)
                {
                    times += duration;
                }
                else
                {
                    times += dif;
                }
            }
            times += duration;
            return times;
        }
    }
}
