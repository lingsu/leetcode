using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.greedy
{
    /// <summary>
    /// 删列造序
    /// </summary>
    public class delete_columns_to_make_sorted
    {
        [Fact]
        public void 删列造序()
        {
            MinDeletionSize(new string[] { "cba", "daf", "ghi" }).ShouldBe(1);
            MinDeletionSize(new string[] { "a", "b" }).ShouldBe(0);
            MinDeletionSize(new string[] { "zyx", "wvu", "tsr" }).ShouldBe(3);
        }
        public int MinDeletionSize(string[] A)
        {
            var nas = 0;

            for (int i = 0; i < A[0].Length; i++)
            {
                for (int j = 1; j < A.Length; j++)
                {
                    if (A[j - 1][i] > A[j][i])
                    {
                        nas++;
                        break;
                    }
                }
            }

            return nas;
        }
    }
}
