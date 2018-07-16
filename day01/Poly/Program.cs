using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poly
{
    class Program
    {
        /** 多态性意味着有多重形式，在面向对象的编程范式中，多态性往往表现为“一个接口，多个功能”
         * 多态性可以是静态的或者是动态的，
         * 在静态多态性中，函数的响应是在编译时发生的。
         * 在动态多态性中，函数的响应是在运行中发生的
         * 
         * 
         * 静态多态性
         * 在编译时，函数和对象的连接机制被称为早期绑定，也被称为静态绑定
         * C#提供了两种技术来实现静态多态性，分别是函数重载、运算符重载
         * 
         */
 
        /**
         * 函数重载 
         */
        void print(int a)
        {
            Console.WriteLine("打印int :{0}", a);
        }

        void print(float a)
        {
            Console.WriteLine("打印flotat :{0}", a);
        }

        void print(double a)
        {
            Console.WriteLine("打印double :{0}", a);
        }

        static void Main(string[] args)
        {
            int a = 10;
            float f = 10.0f;
            double d = 9.99;

            Program p = new Program();
            p.print(a);
            p.print(f);
            p.print(d);
            Console.ReadKey();
        }
    }
}
