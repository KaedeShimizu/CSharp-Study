namespace fangfa
{
    class Program
    {
        // 定义一个方法，传入两个参数
        public int FindMax(int num1, int num2)
        {
            if (num1 >= num2)
                return num1;
            else
                return num2;
        }

        // 递归方法
        public int factorial(int num)
        {
            /* 局部变量定义 */
            int result;
            // 如果就是1的话直接返回1
            if (num == 1)
            {
                return 1;
            }
            else
            {
                // 不是的话，让他乘以num - 1的数值
                result = factorial(num - 1) * num;
                // 最后返回结果，也就是num * num - 1 * num - 2 ... == num!
                return result;
            }
        }
        
        // 值传递和地址传递
        public void SwepTwoNums1(int a, int b)
        {
            // 这是值传递，现在交换两个变量
            int temp = a;
            a = b;
            b = temp;
        }
        public void SwepTwoNums2(ref int a, ref int b)
        {
            // 这里地址传递，同样的交换代码
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            //调用上面的方法
            // 首先要创建一个当前class的实例
            Program p = new Program();
            // 然后用点来调用显示
            Console.WriteLine("{0}", p.FindMax(10, 20));

            // 调用递归方法计算阶乘
            Console.WriteLine(p.factorial(10));

            // 尝试用值传递处理数据
            int num1 = 10;
            int num2 = 20;
            p.SwepTwoNums1(num1, num2);
            Console.WriteLine("{0}, {1}", num1, num2);
            // 再用地址传递处理数据，就会发现成功更改了
            p.SwepTwoNums2(ref num1, ref num2);
            Console.WriteLine("{0}, {1}", num1, num2);
        }
    }
}
