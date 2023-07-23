namespace shujuleixing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 其实我觉得和C++之类的差不多，这里先介绍值类型
            // 其实就是布尔啊之类的数据类型，下面看看他们的大小吧
            // 使用默认的sizeof方法查看类型或者变量占用的大小
            Console.WriteLine("The size of bool is {0}", sizeof(bool));
            Console.WriteLine("The size of byte is {0}", sizeof(byte));
            Console.WriteLine("The size of char is {0}", sizeof(char));
            // 128位精确十进制
            Console.WriteLine("The size of decimal is {0}", sizeof(decimal));
            Console.WriteLine("The size of double is {0}", sizeof(double));
            Console.WriteLine("The size of float is {0}", sizeof(float));
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of long is {0}", sizeof(long));
            // 8位有符号整形
            Console.WriteLine("The size of sbyte is {0}", sizeof(sbyte));
            Console.WriteLine("The size of short is {0}", sizeof(short));
            // u开头的就代表是无符号的
            Console.WriteLine("The size of uint is {0}", sizeof(uint));
            Console.WriteLine("The size of ulong is {0}", sizeof(ulong));
            Console.WriteLine("The size of ushort is {0}", sizeof(ushort));

            // 还有一些非常特殊的类型，比如对象类型
            object obj;
            // 给这个变量进行赋值，就叫做装箱
            obj = 100;
            Console.WriteLine(obj);

            // 或者动态数据类型，在编译的时候确定数据类型
            dynamic d = 20;
            Console.WriteLine(d);

            // 以及最常用的字符串类型，直接用String就行
            // 这里大写小写名称差别不大，但是因为是变量，还是用小写比较好
            string name = "Kaede";
            Console.WriteLine(name);

            // 还有特殊的引号字符串，类似于超级字符串
            // 会自动把里面的转义字符转换为普通字符串
            string str = @"C:\Windows";
            // string str = "C:\\Windows";
            Console.WriteLine(str);

            // 同时这种字符串是可以换行的 换行符及缩进空格都计算在字符串长度之内
            string str2 = @"
    Hello World
    Kaede
";
            Console.WriteLine(str2);

            // 还有指针类型，和Cpp是一样的
            // 这里会涉及到不安全代码的问题，防止报错，可以加一个不安全代码块
            // 这里不多作掩饰，后面就知道了
        }
    }
}