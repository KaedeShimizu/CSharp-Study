namespace changliang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 最常见的常量就是普通的数据，包括了各种数字类型，比如十六进制之类的东西
            Console.WriteLine("这就是一个普通的常量");
            Console.WriteLine(215u);
            Console.WriteLine("转义字符\n换行啦");

            // 也可以定义一个常量
            const double PI = 3.1415926;
            Console.WriteLine(PI);
        }
    }
}