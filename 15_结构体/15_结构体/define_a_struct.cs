using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 结构体可以定义在外面
struct Books
{
    // 一般结构体的属性都是共有的
    public string title;
    public string author;
    public string subject;
    public int book_id;
}

namespace _15_结构体
{
    internal class define_a_struct
    {
        public void main()
        {
            // 可以声明一个书的对象
            Books Book1;
            /* book 1 详述 */
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;
            /* 打印 Book1 信息 */
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);
        }
    }
}
