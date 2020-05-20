using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.sort
{
    /// <summary>
    /// 三角形的最大周长

    /// </summary>
    public class largest_perimeter_triangle
    {
        [Fact]
        //        给定由一些正数（代表长度）组成的数组 A，返回由其中三个长度组成的、面积不为零的三角形的最大周长。

        //如果不能形成任何面积不为零的三角形，返回 0。
        public void 三角形的最大周长()
        {
            LargestPerimeter(new int[] { 2, 1, 2 }).ShouldBe(5);
        }
        public int LargestPerimeter(int[] A)
        {
            Array.Sort(A);

            for (int i = A.Length - 3; i >= 0; i--)
            {
                if (A[i] + A[i + 1] > A[i + 2])
                {
                    return A[i] + A[i + 1] + A[i + 2] ;
                }
            }

            return 0;
        }
    }
}
