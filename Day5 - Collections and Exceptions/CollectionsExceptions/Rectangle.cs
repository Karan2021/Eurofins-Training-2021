using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExceptions
{
    class Rectangle : Shape
    {
        int length, width;

        public Rectangle(string color, int length, int width)
        {
            setColor(color);
            this.length = length;
            this.width = width;
        }

        public override double Area(int length,int width)
        {
            return length * width;
        }

        public void displayArea()
        {
            double area = Area(length,width);
            Console.WriteLine("Area of "+getColor()+" Rectangle is "+area);
        }
    }
}
