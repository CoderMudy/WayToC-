using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            /** 
             * 隐式类型转换：
             * 这些转换是C#默认的以安全方式进行的转换 例如从小的证书类型转换为大的整数类型，从派生类转换为基类
             * 显式类型转换:
             * 这些转换是通过用户使用预定义的函数显式完成的，显式转换需要强制转换运算符
             * 
             */ 
            double d = 5673.74;
            int i;

            //强制转换double为int
            i = (int)d;
            Console.WriteLine(i);


            /** C# 提供了下列内置的类型转换方法
             *  ToBoolen
             *  ToByte
             *  ToChar
             *  ToDateTime 把类型转换为日期时间 结构
             */

            int i2 = 99;
            double d2 = 99.9;
            float f2 = 99.999f;
            bool b = true;

            Console.WriteLine(i2.ToString());
            Console.WriteLine(d2.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(b.ToString());//True

            Console.ReadKey();
        }
    }
}
