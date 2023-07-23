using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_数组
{
    internal class Array_Class
    {
        // 在这里我会介绍数组这个类
        public void fangfa()
        {
            // 首先创建一个数组
            int[] list = { 11, 33, 565, 22, 66, 88, 34, 235 };
            Console.Write("原始数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 逆转数组
            Array.Reverse(list);
            Console.Write("逆转数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 排序数组
            Array.Sort(list);
            Console.Write("排序数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
