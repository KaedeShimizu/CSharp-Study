namespace leixingzhuanhuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 和其他语言差不多，这里直接展示
            // 隐式转换
            byte a = 10;
            int num = a;
            Console.WriteLine("{0}, {1}", a, num);

            // 显示转换，其实就是强制类型转换
            // 显式转换是指将一个较大范围的数据类型转换为较小范围的数据类型时，或者将一个对象类型转换为另一个对象类型时，需要使用强制类型转换符号进行显示转换，强制转换会造成数据丢失。
            int i = 10;
            byte b = (byte)i;
            Console.WriteLine("{0}, {1}", i, b);

            // 当然，C# 提供了下列内置的类型转换方法：
            /*
                1	ToBoolean
                如果可能的话，把类型转换为布尔型。
                2	ToByte
                把类型转换为字节类型。
                3	ToChar
                如果可能的话，把类型转换为单个 Unicode 字符类型。
                4	ToDateTime
                把类型（整数或字符串类型）转换为 日期-时间 结构。
                5	ToDecimal
                把浮点型或整数类型转换为十进制类型。
                6	ToDouble
                把类型转换为双精度浮点型。
                7	ToInt16
                把类型转换为 16 位整数类型。
                8	ToInt32
                把类型转换为 32 位整数类型。
                9	ToInt64
                把类型转换为 64 位整数类型。
                10	ToSbyte
                把类型转换为有符号字节类型。
                11	ToSingle
                把类型转换为小浮点数类型。
                12	ToString
                把类型转换为字符串类型。
                13	ToType
                把类型转换为指定类型。
                14	ToUInt16
                把类型转换为 16 位无符号整数类型。
                15	ToUInt32
                把类型转换为 32 位无符号整数类型。
                16	ToUInt64
                把类型转换为 64 位无符号整数类型。 
            */
            // 比如下面这样子
            i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool ab = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(ab.ToString());
        }
    }
}