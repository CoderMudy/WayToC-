using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 一些有效的变量定义
             * int i, j, k;
             * float f, salary;
             * 可以在变量定义时进行初始化 
             * int i = 100;
             */ 

            /** 接收来自用户的值 并存储到一个变量中
             *  
             */

            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("您输入的是{0}",num);
            Console.ReadKey();
                
        }
    }
}
