using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicGrammar
{
    class Rectangle
    {
        //成员变量
        double length;
        double width;

        //赋值
        public void AcceptDetails() 
        {
            length = 5;
            width = 7;
        }

        //获得面积
        public double Getarea() 
        {
            return length * width;
        }

        //打印宽高 以及面积
        public void Display()
        {
            Console.WriteLine("Length {0} {1}", length,width);
            Console.WriteLine("Width {0}", width);
            Console.WriteLine("Area {0}", Getarea());
        }
    }

    class Excute
    {
     static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
            Console.ReadKey();
        }
    }

}

/**
 * 成员变量: height width
 * 成员函数:AcceptDetails  Getarea Display
 * 实例化一个类:Rectangle r = new Rectangle();
 */