using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.greedy
{
    /// <summary>
    /// 次取反后最大化的数组和
    /// </summary>
    public class maximize_sum_of_array_after_k_negations
    {
        [Fact]
        public void 次取反后最大化的数组和()
        {
            LargestSumAfterKNegations(new int[] { 4, 2, 3 }, 1).ShouldBe(5);
            LargestSumAfterKNegations(new int[] { 3, -1, 0, 2 }, 3).ShouldBe(6);
            LargestSumAfterKNegations(new int[] { 2, -3, -1, 5, -4 }, 2).ShouldBe(13);
        }
        public int LargestSumAfterKNegations(int[] A, int K)
        {
            for (int i = 0; i < K; i++)
            {
                var min = 0;

                for (int j = 1; j < A.Length; j++)
                {
                    if (A[min] > A[j])
                    {
                        min = j;
                    }
                }
                A[min] = -A[min];
            }
            return A.Sum(x => x);
        }
    }
}
