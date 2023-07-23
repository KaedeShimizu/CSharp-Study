using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_枚举
{
    internal class basic_use
    {
        // 创建一个枚举类型
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        public void main()
        {
            // 枚举列表中的每个符号代表一个整数值，一个比它前面的符号大的整数值。默认情况下，第一个枚举符号的值是 0.
            int x = (int)Day.Sun;
            int y = (int)Day.Thu;
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }
}
