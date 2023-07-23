/*
 C# 是一种面向对象的编程语言。在面向对象的程序设计方法中，程序由各种相互交互的对象组成。相同种类的对象通常具有相同的类型，或者说，是在相同的 class 中。
*/

namespace jibenyufa
{
    //创建一个长方形的类
    class Rectangle
    {
        // 成员变量
        double length;
        double width;

        // 成员方法
        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化一个长方形
            Rectangle r = new Rectangle();
            // 调用方法初始化长方形
            r.AcceptDetails();
            // 调用方法显示数据
            r.Display();
        }
    }
}