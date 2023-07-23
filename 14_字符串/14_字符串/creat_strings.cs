using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_字符串
{
    internal class creat_strings
    {
        // 创建字符串
        public void main()
        {
            /*
            通过给 String 变量指定一个字符串
            通过使用 String 类构造函数
            通过使用字符串串联运算符（ + ）
            通过检索属性或调用一个返回字符串的方法
            通过格式化方法来转换一个值或对象为它的字符串表示形式
            */
            // 直接创建字符串
            string fname, lname;
            fname = "Kaede";
            lname = "Shimizu";

            // 字符串拼接
            string fullname = fname + " " + lname;
            Console.WriteLine("Full name is {0}", fullname);

            // 也可以用构造函数来创建
            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            string greeting = new string(letters);
            Console.WriteLine("Greeting is {0}", greeting);

            // 当然，也可以用方法来返回一个字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message is {0}", message);

            // 也可以通过转化值的方法获取字符串
            DateTime waiting = new DateTime(2023, 7, 18, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Chat is {0}", chat);
        }
    }
}
