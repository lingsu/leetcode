using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace Leetcode.bit_manipulation
{
    /// <summary>
    /// 数字转换为十六进制数
    /// </summary>
    public class convert_a_number_to_hexadecimal
    {
        [Fact]
        public void 数字转换为十六进制数()
        {

            ToHex(0).ShouldBe("0");
            ToHex(26).ShouldBe("1a");
            ToHex(-1).ShouldBe("ffffffff");
        }
        public string ToHex(int num)
        {
            var chars = "0123456789abcdef";
            var sb = new StringBuilder();
            do
            {
                var lowbit4 = num & 0xf;
                sb.Append(chars[lowbit4]);
                num >>= 4;
            } while (num != 0 && sb.Length < 8);

            return string.Join("", sb.ToString().Reverse());
        }
    }
}
