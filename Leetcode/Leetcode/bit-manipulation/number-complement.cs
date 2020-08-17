using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 
    /// </summary>
    public class number_complement
    {
        //        给定一个正整数，输出它的补数。补数是对该数的二进制表示取反。



        //示例 1:

        //输入: 5
        //输出: 2
        //解释: 5 的二进制表示为 101（没有前导零位），其补数为 010。所以你需要输出 2 。
        //示例 2:

        //输入: 1
        //输出: 0
        //解释: 1 的二进制表示为 1（没有前导零位），其补数为 0。所以你需要输出 0 。


        //注意:

        //给定的整数保证在 32 位带符号整数的范围内。
        //你可以假定二进制数不包含前导零位。
        //本题与 1009 https://leetcode-cn.com/problems/complement-of-base-10-integer/ 相同

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/number-complement
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        [Theory]
        [InlineData(5, 2)]
        [InlineData(1, 0)]

        public void 数字的补数(int input, int result)
        {
            FindComplement(input).ShouldBe(result);
        }
        public int FindComplement(int num)
        {
            var res = 0;
            var j = 0;
            while (num != 0)
            {
                var lowbit1 = num & 1;
                res += (1 - lowbit1) * (int)Math.Pow(2, j);
                num >>= 1;
                j++;
            }
            return res;
        }
    }
}
