using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.sort
{
    /// <summary>
    /// 数组的相对排序
    /// </summary>
    public class relative_sort_array
    {
        //        给你两个数组，arr1 和 arr2，

        //arr2 中的元素各不相同
        //arr2 中的每个元素都出现在 arr1 中
        //对 arr1 中的元素进行排序，使 arr1 中项的相对顺序和 arr2 中的相对顺序相同。未在 arr2 中出现过的元素需要按照升序放在 arr1 的末尾。



        //示例：

        //输入：arr1 = [2,3,1,3,2,4,6,7,9,2,19], arr2 = [2,1,4,3,9,6]
        //        输出：[2,2,2,1,4,3,3,9,6,7,19]


        //        提示：

        //arr1.length, arr2.length <= 1000
        //0 <= arr1[i], arr2[i] <= 1000
        //arr2 中的元素 arr2[i] 各不相同
        //arr2 中的每个元素 arr2[i] 都出现在 arr1 中

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/relative-sort-array
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        [Fact]
        public void 数组的相对排序()
        {
            RelativeSortArray(new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new int[] { 2, 1, 4, 3, 9, 6 }).ShouldBe(new int[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 });
        }
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var t = new int[1001];
            foreach (var a1 in arr1)
            {
                t[a1]++;
            }
            var s = 0;
            for (int i = 0; i < arr2.Length; i++)
            {

                while (t[arr2[i]] > 0)
                {
                    arr1[s] = arr2[i];
                    t[arr2[i]]--;
                    s++;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                while (t[i] > 0)
                {
                    arr1[s] = i;
                    t[i]--;
                    s++;
                }
            }

            return arr1;
        }
    }
}
