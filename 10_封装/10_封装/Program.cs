namespace fengzhuang
{
    // 创建一个长方形类
    class Rectangle
    {
        // 成员变量，这里用共有，方便外部访问
        public double height;
        public double width;

        // 方法，获取这个长方形的面积
        public double GetArea()
        {
            return this.height * this.width;
        }

        // 方法，输出这个长方形的相关信息
        public void Display()
        {
            Console.WriteLine("Height is {0}, width is {1}", height, width);
            Console.WriteLine("Area is {0}", GetArea());
        }
    }
    // 创建一个圆类，这个类会使用私有化的属性
    class Round
    {
        // 半径
        private double r;
        // 初始化方法
        public void InitRound(double r)
        {
            // 通过传参设置圆的半径
            this.r = r;
        }

        // 获取圆的面积
        public double GetArea()
        {
            return this.r * this.r * 3.1415926;
        }

        // 显示函数
        public void Display()
        {
            Console.WriteLine("r is {0}, Area is {1}", this.r, GetArea());
        }
    }
    // 带有 internal 访问修饰符的任何成员可以被定义在该成员所定义的应用程序内的任何类或方法访问。
    // 这里不演示了，感觉用的不多
    internal class Program
    {
        static void Main(string[] args)
        {
            // 封装 被定义为"把一个或多个项目封闭在一个物理的或者逻辑的包中"。在面向对象程序设计方法论中，封装是为了防止对实现细节的访问。

            // 抽象和封装是面向对象程序设计的相关特性。抽象允许相关信息可视化，封装则使开发者实现所需级别的抽象。

            // 实例化一个长方形
            Rectangle r = new Rectangle();
            // 对这个长方形进行初始化
            r.height = 13.5;
            r.width = 56.5;
            // 显示长方形的信息
            r.Display();

            // 实例化一个圆
            Round round = new Round();
            round.InitRound(80);
            round.Display();
        }
    }
}