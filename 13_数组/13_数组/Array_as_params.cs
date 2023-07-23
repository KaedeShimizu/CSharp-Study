using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_数组
{
    internal class Array_as_params
    {
        // 写一个函数，这个函数可以传入一个数组作为参数
        public double getAverage(int[] arr)
        {
            // 总和设置为0
            int sum = 0;
            // for循环遍历
            for (int i = 0; i < arr.Length; ++i)
            {
                // 加和
                sum += arr[i];
            }
            // 计算平均数
            return (double)sum / arr.Length;
        }
        public void main()
        {
            // 创建一个数组
            int[] list = { 10, 23, 34, 45, 56, 67, 78, 98, 43 };
            Array_as_params aap = new Array_as_params();
            Console.WriteLine("平均数为{0}", aap.getAverage(list));
        }
    }
}
