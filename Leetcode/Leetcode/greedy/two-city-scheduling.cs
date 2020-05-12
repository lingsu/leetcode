using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.greedy
{
    /// <summary>
    /// 两地调度
    /// </summary>
    public class two_city_scheduling
    {
        //公司计划面试 2N 人。第 i 人飞往 A 市的费用为 costs[i][0]，飞往 B 市的费用为 costs[i][1]。

        //返回将每个人都飞到某座城市的最低费用，要求每个城市都有 N 人抵达。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/two-city-scheduling
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        [Fact]
        public void 两地调度()
        {
            TwoCitySchedCost(new int[][] { new[] { 10, 20 }, new[] { 30, 200 }, new[] { 400, 50 }, new[] { 30, 20 } }).ShouldBe(110);
        }

        //我们这样来看这个问题，公司首先将这 2N2N 个人全都安排飞往 BB 市，再选出 NN 个人改变它们的行程，让他们飞往 AA 市。如果选择改变一个人的行程，那么公司将会额外付出 price_A - price_B 的费用，这个费用可正可负。
        //因此最优的方案是，选出 price_A - price_B 最小的 NN 个人，让他们飞往 A 市，其余人飞往 B 市。
        //按照 price_A - price_B 从小到大排序；

        //将前 NN 个人飞往 A 市，其余人飞往 B 市，并计算出总费用。
        //作者：LeetCode
        //链接：https://leetcode-cn.com/problems/two-city-scheduling/solution/er-cha-shu-de-chui-xu-bian-li-by-leetcode/
        //来源：力扣（LeetCode）
        //著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。

        public int TwoCitySchedCost(int[][] costs)
        {
            Array.Sort(costs, (o1, o2) => o1[0] - o1[1] - (o2[0] - o2[1]));
            //var toA = costs.OrderBy((x) => x[0] - x[1]);

            var total = 0;
            var n = costs.Length / 2;

            for (int i = 0; i < n; i++)
            {
                total += costs[i][0] + costs[i + n][1];
            }
            return total;
            //var a = costs.Length / 2;
            //var b = costs.Length / 2;
            //var cost = 0;

            //for (int i = 0; i < costs.Length; i++)
            //{
            //    var temp = costs.Length / 2;

            //    if (costs[i][0] < costs[i][1])
            //    {
            //        for (int j = 0; j < costs.Length; j++)
            //        {
            //            if (costs[j][0] < costs[i][0])
            //            {
            //                temp--;
            //            }
            //        }
            //        if (a > 0 && temp > 0)
            //        {
            //            a--;
            //            cost += costs[i][0];
            //        }
            //        else
            //        {
            //            if (b > 0)
            //            {
            //                b--;
            //                cost += costs[i][1];
            //            }
            //            else
            //            {
            //                a--;
            //                cost += costs[i][0];
            //            }

            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < costs.Length; j++)
            //        {
            //            if (costs[j][1] < costs[i][1])
            //            {
            //                temp--;
            //            }
            //        }
            //        if (b > 0 && temp > 0)
            //        {
            //            b--;
            //            cost += costs[i][1];
            //        }
            //        else
            //        {
            //            if (a > 0)
            //            {
            //                a--;
            //                cost += costs[i][0];
            //            }
            //            else
            //            {
            //                b--;
            //                cost += costs[i][1];
            //            }
            //        }
            //    }
            //}
            //return cost;
        }
    }
}
