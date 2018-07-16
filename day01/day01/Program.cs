using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * using 关键字用于在程序中包含System命名空间。一个程序一般有多个using语句
 * 下一行是namespace声明，一个namespace是一系列的类。
 *  Console.ReadKey(); 是针对VS.NET用户的。这使得程序会等待一个按键的动作，防止启动时屏幕会快速运行并关闭
 * 
 */

namespace day01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.ReadKey();
        }
    }
}


