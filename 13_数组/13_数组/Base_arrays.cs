using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_数组
{
    internal class Base_arrays
    {
        public void main()
        {
            // 声明一个数组
            // int里面的内容默认是0
            int[] ints = new int[10];

            // 对数组里面的元素进行修改
            ints[0] = 100;
            // 显示数组里面的内容
            foreach (int i in ints)
            {
                Console.Write("{0}.", i);
            }

            // 也可以直接在创建的时候初始化数组
            int[] ints1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach (int i in ints1)
            {
                Console.Write("{0}.", i);
            }
        }
    }
}
