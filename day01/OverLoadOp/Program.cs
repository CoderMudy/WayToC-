using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverLoadOp
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;


        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bread)
        {
            breadth = bread;
        }

        public void setHeight(double heig)
        {
            height = heig;
        }
        /**
         * 运算符重载
         * 
         */ 
        public static Box operator+(Box b1,Box b2)
        {
            Box newB = new Box();
            newB.height = b1.height + b2.height;
            newB.breadth = b1.breadth + b2.breadth;
            newB.length = b1.length + b2.length;
            return newB;
        }

        static void Main(string[] args)
        {
            Box b1 = new Box();
            b1.setBreadth(10);
            b1.setHeight(20);
            b1.setLength(30);


            Box b2 = new Box();
            b2.setBreadth(1);
            b2.setHeight(2);
            b2.setLength(3);

            Box b3 = new Box();
            b3 = b1 + b2;
            Console.WriteLine("两个加一起的体积是{0}",b3.getVolume());
            Console.ReadKey();

        }
    }
}
