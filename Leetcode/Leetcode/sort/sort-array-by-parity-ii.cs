using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.sort
{
    /// <summary>
    /// 按奇偶排序数组 II
    /// </summary>
    public class sort_array_by_parity_ii
    {
        [Fact]
        //给定一个非负整数数组 A， A 中一半整数是奇数，一半整数是偶数。

        //对数组进行排序，以便当 A[i] 为奇数时，i 也是奇数；当 A[i] 为偶数时， i 也是偶数。

        //你可以返回任何满足上述条件的数组作为答案。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/sort-array-by-parity-ii
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public void 按奇偶排序数组II()
        {
            SortArrayByParityII(new int[] { 4, 2, 5, 7 }).ShouldBe(new int[] { 4, 5, 2, 7 });
        }
        public int[] SortArrayByParityII(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 != A[i] % 2)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (i % 2 == A[j] % 2)
                        {
                            var temp = A[i];
                            A[i] = A[j];
                            A[j] = temp;
                            break;
                        }
                    }
                }
            }
            return A;
        }
    }
}
