using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;


    public void getValues(string t, string a, string s ,int id )
    {
        title = t;
        author = a;
        subject = s;
        book_id = id;
    }

    public void display()
    {
        Console.WriteLine("Title:{0}", title);
        Console.WriteLine("author:{0}", author);
        Console.WriteLine("subject:{0}", subject);
        Console.WriteLine("book_id:{0}", book_id);
    }
}

/** 类 VS 结构
 * 类和结构有以下不同点
 * 类是引用类型，结构是值类型
 * 结构不支持继承
 * 结构不能声明默认的构造函数
 * 
 */

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Books b1;
            b1.title = "mudy";
            b1.author = "dede";
            b1.subject = "sin";
            b1.book_id = 111;

            Console.WriteLine("书的信息是 {0}", b1.book_id);


            Books b2 = new Books();
            b2.getValues("t", "a", "s", 001);
            b2.display();
            Console.ReadKey();
        }
    }
}
