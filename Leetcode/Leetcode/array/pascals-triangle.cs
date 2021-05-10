using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.array
{
    /// <summary>
    /// 118. 杨辉三角
    /// </summary>
    public class pascals_triangle
    {
        [Fact]
        public void 杨辉三角()
        {
            var result = Generate(5);
            result.Count.ShouldBe(5);
        }
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            List<int> last = null;

            for (int i = 1; i <= numRows; i++)
            {
                var cur = new List<int>();
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || j == i-1)
                    {
                        cur.Add(1);
                    }
                    else
                    {
                        var left = j - 1;
                        var right = j;
                        cur.Add(last[left]+ last[right]);
                    }
                }
                last = cur;
                result.Add(cur);
            }

            return result;
        }
    }
}
