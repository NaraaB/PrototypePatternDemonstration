using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo
{
    public class Rectangle : Shape
    {
        public int width, height;
        public Rectangle()
        {
            type = "Rectangle";
        }

        public override double GetArea()
        {
            area = width * height;
            return area;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Shape))
                return false;
            Rectangle shape = (Rectangle)obj;
            return shape.height == height && shape.width == width;
        }
    }
}
