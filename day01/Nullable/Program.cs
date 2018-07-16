using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nullable
{
    class Program
    {

        /** 声明一个nullable类型的语法
         * <data_type> ? <variable_name> = null;
         */

        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14;
            bool? boolval = new bool?();

            //
            Console.WriteLine("显示可空类型的值 num1:{0} num2:{1} num3:{2} num4:{3} boolval:{4}",num1,num2,num3,num4,boolval);
            Console.ReadKey();


            /** ??
             * num3 = num1 ?? 4;
             * 如果第一个操作数的值为null,则运算符返回第二个操作数的值，否则返回第一个操作数的值
             * 
             */ 

        }
    }
}
