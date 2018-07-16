using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            /** 定义常量
             * 常量是使用const关键字来定义的，定义一个常量的语法
             * const <data_type> <const_name> = value;
             */
            const double pi = 3.14;//常量声明
            double r;
            Console.WriteLine("请输入半径");
            r = Convert.ToInt32(Console.ReadLine());
            double areaCirce = pi * r * r;
            Console.WriteLine("半径:{0},面积{1}",r,areaCirce);
            Console.ReadKey();
        }
    }
}
