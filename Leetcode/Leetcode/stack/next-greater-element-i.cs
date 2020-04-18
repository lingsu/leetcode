using System.Collections.Generic;
using Xunit;
using Shouldly;

namespace Leetcode.stack
{
    /// <summary>
    ///  下一个更大元素 I
    /// </summary>
    public class next_greater_element_i
    {
        [Fact]
        public void 下一个更大元素I()
        {
            var nums1 = new int[] { 4, 1, 2 };
            var nums2 = new int[] { 1, 3, 4, 2 };
            NextGreaterElement(nums1, nums2).ShouldBe(new int[] { -1, 3, -1 });
        }

        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
            {
                return new int[] { };
            }
            
            var result = new int[nums1.Length];
            var dic = new Dictionary<int, int>();
            var stack = new Stack<int>();
            stack.Push(nums2[0]);
            for (int i = 1; i < nums2.Length; i++)
            {
                var ss = nums2[i];
                var front = stack.Peek();
                while (stack.Count > 0)
                {
                    if (nums2[i] > front)
                    {
                        dic[stack.Pop()] = ss;
                        if (stack.Count > 0)
                        {
                            front = stack.Peek();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
               
                stack.Push(ss);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dic.ContainsKey(nums1[i]))
                {
                    result[i] = dic[nums1[i]];
                }
                else
                {
                    result[i] = -1;
                }
            }

            return result;
        }
        //public int[] NextGreaterElement(int[] nums1, int[] nums2)
        //{
        //    var result = new int[nums1.Length];
        //    for (int i = 0; i < nums1.Length; i++)
        //    {
        //        result[i] = -1;
        //        var s = -1;
        //        for (int j = 0; j < nums2.Length; j++)
        //        {
        //            if (nums1[i] == nums2[j])
        //            {
        //                s = j;
        //                break;
        //            }
        //        }

        //        for (; s < nums2.Length; s++)
        //        {
        //            if (nums2[s] > nums1[i])
        //            {
        //                result[i] = nums2[s];
        //                break;
        //            }
        //        }
        //    }
        //    return result;
        //}
    }
}
