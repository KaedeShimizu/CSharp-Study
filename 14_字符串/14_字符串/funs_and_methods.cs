using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_字符串
{
    internal class funs_and_methods
    {
        public void main()
        {
            // 比较字符串
            string str1 = "This is test";
            string str2 = "This is text";
            // 这里如果等于0，那么就是相等的，否则不相等
            Console.WriteLine("str1和str2是否相等 {0}", String.Compare(str1, str2) == 0 ? "相等" : "不相等");

            // 判断字符串是否包含另外一个字符串
            string name = "Kaede";
            string chat = "Hello, my name is Kaede";
            Console.WriteLine("是否包含？{0}", chat.Contains(name));

            // 获取子字符串
            // 传入的参数是从第几个字符开始，也就是索引
            string substr = chat.Substring(6);
            Console.WriteLine("子字符串是{0}", substr);

            // 链接字符串
            // 其实就是把几个字符串放到一起
            string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};
            // 传入的就是要加在字符串之间的内容，第二个就是传入的字符串数组
            string str = String.Join("\n", starray);
            Console.WriteLine(str);
        }
    }
}
