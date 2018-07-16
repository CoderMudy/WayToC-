using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inherit
{
    class Shape
    {
        protected int width;
        protected int height;
        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }
    }

    /**
     * c#不支持多继承。但是可以通过接口来实现多重继承
     */

    public interface PaintCost
    {
        Console.WriteLine("接口中的代码");
        int getCost(int area);
    }

    class Rectangle : Shape,PaintCost
    {
        public int getArea()
        {
            return width * height;
        }

        public int getCost(int area)
        {
            return area * 80;
        }
    }

    class Tester
    {
     static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.setHeight(5);
            r.setWidth(7);
            int area = r.getArea();
            Console.WriteLine(area);
            Console.WriteLine("总成本:{0}", r.getCost(area));
            Console.ReadKey();
        }
    }
}
