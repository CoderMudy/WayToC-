using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method
{
    class Program
    {
        /** 参数传递
         * 
         * 值参数:
         * 这种方式复制参数的实际值给函数的形式参数，实参和形参使用的是两个不同内存中的值
         * 这种情况下，当形参的值发生改变时，不会影响实参的值，从而保证了数据的安全，
         * 
         * 引用参数:
         * 这种方式复制参数的内存位置的引用给形式参数。这意味着当形参的值发生改变时，同时也
         * 实参的值也发生改变
         * 
         * 输出参数:
         * 这种方式可以返回多个值
         * 
         * 
         */ 

        /** 值传递
         * 结果表明，即使在函数内改变了值，值也没有发生任何的变化
         */
        public void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("交换ing a:{0} b:{1}", x, y);
        }

        /** 引用传递
         * 
         * 
         */
        public void rswap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("交换ing a:{0} b:{1}", x, y);
        }

        /** 按输出传递参数
         */
        public void getValue(out int x, out int y)
        {
            //int temp = 5;
            //x = temp;
            Console.WriteLine("请输入第一个值");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入第二个值");
            y = Convert.ToInt32(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            int a = 100;
            int b = 80;
            Console.WriteLine("交换之前a:{0} b:{1}", a, b);
            
            //p.swap(a, b);//

            //p.rswap(ref a,ref b);
            
            p.getValue(out a,out b);
            Console.WriteLine("交换之后a:{0} b:{1}", a, b);
            Console.ReadKey();
        }
    }
}



