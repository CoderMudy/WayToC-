using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    class Program
    {
        /** 构造函数 带参数
         */
        private double lineWidth, lineHeight;
        public Program(double width, double height) 
        {
            Console.WriteLine("对象已经创建");
            lineWidth = width;
            lineHeight = height;
        }

        public double getlineWidth()
        {
            Console.WriteLine("线条的宽是{0} 线条的长是{1}",lineWidth,lineHeight);
            return lineWidth;
        }

        //析构函数 
        ~Program()
        {
            Console.WriteLine("这里是析构函数");
        }

        static void Main(string[] args)
        {
            Program p = new Program(5,6);
            double w = p.getlineWidth();

            Console.ReadKey();
        }
    }
}


/** 静态成员
 * 
 * 当我们声明一个类成员为静态是，意味着无论有多少个类的对象呗创建，只会有一个该静态成员的副本
 * 
 * 也可以把一个函数声明为static，这样的函数只能访问静态变量。静态函数在对象被创建之前就已经存在。
 */