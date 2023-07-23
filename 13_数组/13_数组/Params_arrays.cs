using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_数组
{
    internal class Params_arrays
    {
        public void main()
        {
            int AddElements(params int[] arr)
            {
                int sum = 0;
                foreach (int i in arr)
                {
                    sum += i;
                }
                return sum;
            }
            // 简单说就是可以通过params关键字，传入n个数据，最后自动转换为数组
            Console.WriteLine(AddElements(10, 20, 30, 40, 50, 60, 70));
        }
    }
}
