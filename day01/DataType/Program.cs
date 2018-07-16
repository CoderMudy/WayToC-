using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型
            Console.WriteLine("size of int is {0}",sizeof(int));           
           

            /** 引用类型
             * 当一个值类型转换为对象类型时，被称为装箱
             * 当一个对象类型转换为值类型时，被称为拆箱
             */
            object obj;
            obj = 100; //这是装箱

            /** 动态类型
             * 可以存储任何类型的值在动态数据类型中。这些变量的类型检查是在运行时发生的
             * 声明动态类型的语法
             * dunamic <变量名> = value
             * 
             * 动态类型与对象类型类似，但是对象类型变量的类型检查是在编译时发生的，而动态变量的类型检查是在运行时发生的
             */

            dynamic d = 20;

            /** 字符串类型
             * 
             * string字符串的前面可以加@（称作“逐字字符串”）将转义字符(\)当做普通字符对待
             * String path = @"C:\Windows";
             * 
             * @字符串中可以任意换行 ，换行符及缩进空格都计算在字符串长度之内
             */

            String str = "mudy";
            String str2 = @"mudy";
            String path = @"C:\Windows";
            Console.WriteLine("{0} {1} {2}", str, str2, path);
            string str3 = @"dede
                <>ddede
                    dede";
            Console.WriteLine(str3);

            /** 指针类型
             * 指针类型变量存储另一种类型的内存地址。
             * 声明指针的语法
             * type* identifier;
             */

           // char* cptr;
            Console.ReadKey();

        }
    }
}
