using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_数组
{
    internal class Multidimensional_arrays
    {
        // 这是多维数组
        public void main()
        {
            // 定义多维数组
            int[,] ints2 =
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
            };
            // 遍历这个多维数组
            // foreach是默认从第一个开始的
            foreach (int i in ints2)
            {
                Console.WriteLine("{0}", i);
            }
            // 也可以按照顺序来访问，直接就是方括号里面的index索引
            Console.WriteLine("{0}", ints2[0, 2]);

        }
    }
}
