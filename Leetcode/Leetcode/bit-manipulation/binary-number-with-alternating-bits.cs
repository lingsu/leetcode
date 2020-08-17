using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 交替位二进制数
    /// </summary>
    public class binary_number_with_alternating_bits
    {
        //        给定一个正整数，检查他是否为交替位二进制数：换句话说，就是他的二进制数相邻的两个位数永不相等。

        //示例 1:

        //输入: 5
        //输出: True
        //解释:
        //5的二进制数是: 101
        //示例 2:

        //输入: 7
        //输出: False
        //解释:
        //7的二进制数是: 111
        //示例 3:

        //输入: 11
        //输出: False
        //解释:
        //11的二进制数是: 1011
        // 示例 4:

        //输入: 10
        //输出: True
        //解释:
        //10的二进制数是: 1010

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/binary-number-with-alternating-bits
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        [Theory]
        [InlineData(5,true)]
        [InlineData(7,false)]
        [InlineData(11,false)]
        [InlineData(10, true)]
        public void 交替位二进制数(int input, bool result)
        {
            HasAlternatingBits(input).ShouldBe(result);
        }
        public bool HasAlternatingBits(int n)
        {
            n = (n ^ (n >> 1));
            return (n & ((long)n + 1)) == 0;
        }
    }
}
