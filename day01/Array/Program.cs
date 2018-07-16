using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        /**传递数组给函数
         */

        double getAverage(int[] n,int size)
        {
            int sum = 0;
            foreach(int i in n)
            {
                sum += i;
            }
            
            return sum / size;
        }

        static void Main(string[] args)
        {
            int[] n = new int[10];//n是一个带有10个整数的数组

            //初始化数组中的元素
            for (int i = 0; i < 10; i++ )
            {
                n[i] = i + 100;
            }

            //读取数组中的元素
            for (int j = 0; j < 10; j++ )
            {
                Console.WriteLine("数组n中的第{0}个元素是{1}", j, n[j]);
            }

            //使用fireach循环
            foreach(int j in n)
            {
                Console.WriteLine("数组n中的元素是{0}",j);
            }

            Program p = new Program();

            Console.WriteLine("这个数组的均值是{0}", p.getAverage(n,10));

            Console.ReadKey();
        }
    }
}
