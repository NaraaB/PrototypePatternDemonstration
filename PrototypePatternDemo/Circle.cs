using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo
{
    public class Circle : Shape
    {
        public int radius;
        public Circle()
        {
            type = "Circle";
        }

        public override double GetArea()
        {
            area = 2*3.14*radius * radius;
            return area;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Shape))
                return false;
            Circle shape = (Circle)obj;
            return shape.radius == radius;
        }
    }
}
