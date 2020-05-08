using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.greedy
{
    /// <summary>
    /// 柠檬水找零
    /// </summary>
    public class lemonade_change
    {
        [Fact]
        public void 柠檬水找零()
        {
            LemonadeChange(new int[] { 5, 5, 5, 10, 20 }).ShouldBeTrue();
            LemonadeChange(new int[] { 5, 5, 10, 10, 20 }).ShouldBeFalse();
        }
        public bool LemonadeChange(int[] bills)
        {
            if (bills == null || bills.Length == 0)
            {
                return false;
            }

            var five = 0;
            var ten = 0;

            foreach (var b in bills)
            {
                if (b == 5)
                {
                    five++;
                }
                else if (b == 10)
                {
                    if (five == 0)
                    {
                        return false;
                    }
                    five--;
                    ten++;
                }
                else
                {
                    if (five > 0 && ten > 0)
                    {
                        ten--;
                        five--;
                    }
                    else if (five >= 3)
                    {
                        five -= 3;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
