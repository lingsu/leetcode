using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.sort
{
    /// <summary>
    /// 去掉最低工资和最高工资后的工资平均值
    /// </summary>
    public class average_salary_excluding_the_minimum_and_maximum_salary
    {
        [Fact]
        public void 去掉最低工资和最高工资后的工资平均值()
        {
            Average(new int[] { 4000, 3000, 1000, 2000 }).ShouldBe(2500);
            Average(new int[] { 1000, 2000, 3000 }).ShouldBe(2000);
            Average(new int[] { 6000, 5000, 4000, 3000, 2000, 1000 }).ShouldBe(3500);
            Average(new int[] { 48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000 }).ShouldBe(41111.11111111111);
        }

        public double Average(int[] salary)
        {
            var sum = 0;
            var min = int.MaxValue;
            var max = int.MinValue;
            foreach (var money in salary)
            {
                sum += money;
                min = Math.Min(min, money);
                max = Math.Max(max, money);
            }
            sum = sum - min - max;
            return (double)sum / (double)(salary.Length - 2);
        }
    }
}
