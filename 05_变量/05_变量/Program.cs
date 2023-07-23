namespace bianliang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 下面是不同类型的变量
                整数类型	sbyte、byte、short、ushort、int、uint、long、ulong 和 char
                浮点型	float 和 double
                十进制类型	decimal
                布尔类型	true 或 false 值，指定的值
                空类型	可为空值的数据类型
             */

            // 定义一个变量
            int a;

            // 初始化正常就好
            a = 100;
            Console.WriteLine(a);

            // 当然也可以获取用户输入的内容
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Your name is {0}", name);
        }
    }
}